using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
   public interface IOrderService
    {
        Task<ServiceResponse<int>> AddEditOrder(AddEditOrderDto addEditOrderDto, string userFullName);
        Task<ServiceResponse<(List<GetOrderDto>, int)>> GetAllOrders(int pageSize, string search,bool? ispaied);
        Task<ServiceResponse<AddEditOrderDto>> GetOrderForEdit(Guid id);
        Task<ServiceResponse<int>> PayOrder(Guid id,string userFullName);
    }
}
