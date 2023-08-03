using AutoMapper;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Orders;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Interfaces.Services;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHistoryRepository _historyRepository;
        private readonly IProductRepository _productRepository;

        public OrderService(IProductRepository productRepository, IHistoryRepository historyRepository, IMapper mapper, IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _historyRepository = historyRepository;
            _productRepository = productRepository;

        }

        public async Task<ServiceResponse<int>> AddEditOrder(AddEditOrderDto addEditOrderDto, string userFullName)
        {
            try
            {
                string historyDiscription = "";
                var totalcost = addEditOrderDto.Products.Select(a => a.Quantity * a.Cost).Sum();
                if (addEditOrderDto.Id == null)
                {
                    var order = _mapper.Map<Order>(addEditOrderDto);
                    _orderRepository.Create(order);
                    order.Total_Cost = totalcost;
                    var products = await _productRepository.GetAllAsync(a => addEditOrderDto.Products.Select(f => f.ProductId).Any(x => x == a.Id));
                    for (int i = 0; i < addEditOrderDto.Products.Count; i++)
                    {
                        var product = products.Where(a => a.Id == addEditOrderDto.Products[i].ProductId).FirstOrDefault();
                        if (product.Quantity < addEditOrderDto.Products[i].Quantity)
                        {
                            return new ServiceResponse<int> { Data = 0, Success = false, Message = "الكمية المتاحة من المنتج " + product.Name + " تساوي " + product.Quantity };
                        }
                        product.Quantity = product.Quantity - addEditOrderDto.Products[i].Quantity;
                    }

                    historyDiscription = " لقد قام " + userFullName + " باضافة طلب";
                }
                else
                {
                    var order = await _orderRepository.GetOrderWithItsDetailsById(addEditOrderDto.Id.Value);
                    if (order == null) return new ServiceResponse<int> { Data = 0, Success = false, Message = "لا يوجد بيانات" };
                    order.Total_Cost = totalcost;
                    var products = (await _productRepository.GetAllAsync(a => 
                    order.OrderDetails.Select(a=>a.Product_Id).Any(x => x == a.Id)||addEditOrderDto.Products.Select(x=>x.ProductId).Any(f=>f==a.Id))).Distinct().ToList();
                   

                    var oldOrderDetails = order.OrderDetails.Select(d => new CompareDto() { Id = d.Product_Id, Quantity = d.Quantity }).ToList();
                    var newOrderDetails = addEditOrderDto.Products.Select(d => new CompareDto() { Id = d.ProductId, Quantity = d.Quantity }).ToList();
                    
                    var oldupdatedDetails = order.OrderDetails.Where(n=> addEditOrderDto.Products.Any(a=>a.Id==n.Id)).ToList();
                    var newUpdatedDetails = addEditOrderDto.Products.Where(n => order.OrderDetails.Any(a => a.Id == n.Id)).ToList();

        
                    for (int i = 0; i < oldupdatedDetails.Count; i++)
                    {
                        var product = products.Where(a => a.Id == oldupdatedDetails[i].Product_Id).FirstOrDefault();
                        var newupdated = newUpdatedDetails.Where(a => a.Id == oldupdatedDetails[i].Id).FirstOrDefault();
                        if (oldupdatedDetails[i].Quantity > newupdated.Quantity)
                        {
                            product.Quantity = product.Quantity + (oldupdatedDetails[i].Quantity -newupdated.Quantity);
                        }
                        else if(oldupdatedDetails[i].Quantity < newupdated.Quantity)
                        {
                            int addedQuantity = newupdated.Quantity - oldupdatedDetails[i].Quantity;
                            if (product.Quantity < addedQuantity)
                            {
                                return new ServiceResponse<int> { Data = 0, Success = false, Message = "الكمية المتاحة من المنتج " + product.Name + " تساوي " + product.Quantity };
                            }
                            product.Quantity = product.Quantity - addedQuantity;
                        }
                        
                    }

                    var newDetailsIds = newOrderDetails.Select(a=>a.Id).Except(oldOrderDetails.Select(a=>a.Id)).ToList();
                    var newDetails = newOrderDetails.Where(a => newDetailsIds.Any(x => x == a.Id)).ToList();
                    if (newDetails.Any())
                    {
                        for (int i = 0; i < newDetails.Count; i++)
                        {
                            var product = products.Where(a => a.Id == newDetails[i].Id).FirstOrDefault();
                            if (product.Quantity < newDetails[i].Quantity)
                            {
                                return new ServiceResponse<int> { Data = 0, Success = false, Message = "الكمية المتاحة من المنتج " + product.Name + " تساوي " + product.Quantity };
                            }
                            product.Quantity = product.Quantity - newDetails[i].Quantity;
                        }
                    }
                    
                    var deletedDetailsIds = oldOrderDetails.Select(a=>a.Id).Except(newOrderDetails.Select(a=>a.Id)).ToList();
                    var deletedDetails = oldOrderDetails.Where(a => deletedDetailsIds.Any(x => x == a.Id)).ToList();
                    if (deletedDetails.Any())
                    {
                        for (int i = 0; i < newDetails.Count; i++)
                        {
                            var product = products.Where(a => a.Id == deletedDetails[i].Id).FirstOrDefault();                            
                            product.Quantity = product.Quantity + deletedDetails[i].Quantity;
                        }
                    }
                    _mapper.Map<AddEditOrderDto, Order>(addEditOrderDto, order);
                    historyDiscription = "لقد قام " + userFullName + " بتعديل طلب" + order.Order_Id;
                }
               
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                var result = await _unitOfWork.CommitAsync();
                return new ServiceResponse<int> { Data = result, Success = result > 0, Message = result > 0 ? "تمت العملية بنجاح" : "حدثت مشكلة ما" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<int> { Data = 0, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<(List<GetOrderDto>, int)>> GetAllOrders(int pageSize, string search, bool? ispaied)
        {
            try
            {
                (var orders, int length) = await _orderRepository.GetAllOrderstWithPagination(pageSize, search, ispaied);
                if (orders == null || length == 0) return new ServiceResponse<(List<GetOrderDto>, int)> { Data = (new List<GetOrderDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                var ordersDtos = _mapper.Map<List<GetOrderDto>>(orders);
                return new ServiceResponse<(List<GetOrderDto>, int)> { Data = (ordersDtos, length), Success = true };

            }
            catch (Exception ex)
            {
                return new ServiceResponse<(List<GetOrderDto>, int)> { Data = (new List<GetOrderDto>(), 0), Success = false, Message = "حدث خطأ" };

            }
        }

        public async Task<ServiceResponse<AddEditOrderDto>> GetOrderForEdit(Guid id)
        {
            try
            {
                var order = await _orderRepository.GetOrderWithItsDetailsById(id);
                if (order == null) return new ServiceResponse<AddEditOrderDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var dto = _mapper.Map<AddEditOrderDto>(order);
                dto.Id = order.Id;
                for (int i = 0; i < order.OrderDetails.Count; i++)
                {
                    dto.Products[i].ProductName = order.OrderDetails[i].Product.Name;
                    dto.Products[i].Cost = order.OrderDetails[i].Product.Price;
                    dto.Products[i].Id = order.OrderDetails[i].Id;
                }
                return new ServiceResponse<AddEditOrderDto> { Data = dto, Success = true };

            }
            catch (Exception ex)
            {
                return new ServiceResponse<AddEditOrderDto> { Data = null, Success = false, Message = "حدث خطأ" };

            }
        }

        public async Task<ServiceResponse<int>> PayOrder(Guid id, string userFullName)
        {
            try
            {
                var order = await _orderRepository.GetOrderWithItsDetailsById(id);
                if (order == null) return new ServiceResponse<int> { Data = 0, Success = false, Message = "لا يوجد بيانات" };
                order.Is_Paid = true;
                var historyDiscription = " لقد قام " + userFullName + " بدفع طلب" + order.Order_Id;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                var result = await _unitOfWork.CommitAsync();
                return new ServiceResponse<int> { Data = result, Success = result > 0, Message = result > 0 ? "تمت العملية بنجاح" : "حدثت مشكلة ما" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<int> { Data = 0, Success = false, Message = "حدث خطأ" };
            }
        }
    }
}
