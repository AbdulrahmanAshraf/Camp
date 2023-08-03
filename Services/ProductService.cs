using AutoMapper;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Enums;
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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IHistoryRepository _historyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMasterDataRepository _masterDataRepository;
        public ProductService(IHistoryRepository historyRepository, IMasterDataRepository masterDataRepository, IMapper mapper, IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _masterDataRepository = masterDataRepository;
            _historyRepository = historyRepository;
        }

        public async Task<ServiceResponse<(List<GetProductDto>, int)>> GetAllProducts(GridSearchDto paginationDto)
        {
            try
            {
                (var productsDb, int length) = await _productRepository.GetAllProductWithPagination(paginationDto);

                if (productsDb == null || length == 0) return new ServiceResponse<(List<GetProductDto>, int)> { Data = (new List<GetProductDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                var productsDtos = _mapper.Map<List<GetProductDto>>(productsDb);
                return new ServiceResponse<(List<GetProductDto>, int)> { Data = (productsDtos, length), Success = true };

            }
            catch (Exception ex)
            {

                return new ServiceResponse<(List<GetProductDto>, int)> { Data = (new List<GetProductDto>(), 0), Success = false, Message = "حدثت مشكلة ما" };

            }
        }

        public async Task<ServiceResponse<List<DropDown>>> GetAllProductCategories()
        {
            try
            {
                var categoriesDb = await _masterDataRepository.GetAllMasterDataWithParentCode(ProductCategoriesCode.PRTYP.ToString());
                if (categoriesDb == null || categoriesDb.Count == 0) return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var categoriesDtos = _mapper.Map<List<DropDown>>(categoriesDb);
                return new ServiceResponse<List<DropDown>> { Data = categoriesDtos, Success = true };

            }
            catch (Exception ex)
            {

                return new ServiceResponse<List<DropDown>> { Data = null, Success = false, Message = "حدث خطأ" };

            }
        }

        public async Task<ServiceResponse<int>> AddEditProduct(AddEditProductDto addEditProductDto, string userFullName)
        {
            try
            {
                string historyDiscription = "";
                if (addEditProductDto.Id == null)
                {
                    var product = _mapper.Map<Product>(addEditProductDto);
                    product.Quantity = product.Quantity == null ? 0 : product.Quantity;
                    _productRepository.Create(product);
                    historyDiscription = " لقد قام " + userFullName + " باضافة المنتج " + addEditProductDto.Name;
                }
                else
                {
                    var product = _productRepository.FindByID(Guid.Parse(addEditProductDto.Id));
                    if (product == null) return new ServiceResponse<int> { Data = 0, Success = false, Message = "لا يوجد بيانات" };
                    _mapper.Map<AddEditProductDto, Product>(addEditProductDto, product);
                    historyDiscription = "لقد قام " + userFullName + " بتعديل المنتج " + addEditProductDto.Name;
                }
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                var result = await _unitOfWork.CommitAsync();
                return new ServiceResponse<int> { Data = result, Success = result > 0, Message = result > 0 ? "تمت العملية بنجاح" : "حدث خطأ" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<int> { Data = 0, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<AddEditProductDto>> GetProductById(Guid id)
        {
            try
            {
                var product = _productRepository.FindByID(id);
                if (product == null) return new ServiceResponse<AddEditProductDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var dto = _mapper.Map<AddEditProductDto>(product);
                dto.Category = product.Category;
                return new ServiceResponse<AddEditProductDto> { Data = dto, Success = true };

            }
            catch (Exception ex)
            {
                return new ServiceResponse<AddEditProductDto> { Data = null, Success = false, Message = "حدث خطأ" };

            }
        }

        public async Task<ServiceResponse<int>> DeleteProduct(Guid id, string userFullName)
        {
            try
            {
                var product = _productRepository.FindByID(id);
                if (product == null) return new ServiceResponse<int> { Data = 0, Success = false, Message = "لا يوجد بيانات" };
                _productRepository.Delete(product);
                var historyDiscription = " لقد قام " + userFullName + " بحذف المنتج " + product.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                var result = await _unitOfWork.CommitAsync();
                return new ServiceResponse<int> { Data = result, Success = result > 0, Message = result > 0 ? "تمت العملية بنجاح" : "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<int> { Data = 0, Success = false, Message = "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
            }
        }

        public async Task<ServiceResponse<int>> AddNewQuentityToProduct(AddNewQuentityToProductDto addNewQuentity, string userFullName)
        {
            try
            {
                var product = _productRepository.FindByID(addNewQuentity.Id);
                if (product == null) return new ServiceResponse<int> { Data = 0, Success = false, Message = "لا يوجد بيانات" };
                product.Quantity = product.Quantity + addNewQuentity.Quantity;
                var historyDiscription = " لقد قام " + userFullName + " باضافة كمية " + addNewQuentity.Quantity + " للمنتج " + product.Name;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                var result = await _unitOfWork.CommitAsync();
                return new ServiceResponse<int> { Data = result, Success = result > 0, Message = result > 0 ? "تمت العملية بنجاح" : "لم تتم العملية" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<int> { Data = 0, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<GetProductByCategoryDto>>> GetProductByCategory(string category)
        {
            try
            {
                var products = await _productRepository.GetProductByCategory(category);
                if (products == null || products.Count == 0) return new ServiceResponse<List<GetProductByCategoryDto>> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                var dtos = _mapper.Map<List<GetProductByCategoryDto>>(products);
                return new ServiceResponse<List<GetProductByCategoryDto>> { Data = dtos, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<GetProductByCategoryDto>> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }
    }
}
