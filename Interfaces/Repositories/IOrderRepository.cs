using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<Order> GetOrderWithItsDetailsById(Guid id);
        Task<List<Order>> GetTodayOrders();
        Task<(List<Order>, int)> GetAllOrderstWithPagination(int pageSize, string search, bool? ispaied);
        Task<List<Order>> GetAllOrdersIncomesForADatePeriod(DateTime? from, DateTime? to);
    }
}
