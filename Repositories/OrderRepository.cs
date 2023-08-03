using Microsoft.EntityFrameworkCore;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(PlayStationDbContext playStationDbContext) : base(playStationDbContext)
        {

        }

        public async Task<Order> GetOrderWithItsDetailsById(Guid id)
        {
            var order = await _playStationDbContext.Orders.Where(a => a.Id == id).Include(a => a.OrderDetails).ThenInclude(a => a.Product).FirstOrDefaultAsync();
            return order;
        }
        public async Task<(List<Order>, int)> GetAllOrderstWithPagination(int pageSize, string search, bool? ispaied)
        {
            var orders = _playStationDbContext.Orders.Where(a => a.Working_Device_Id == null).OrderByDescending(a => a.Create_Date);
            if (!string.IsNullOrEmpty(search)) orders = orders.Where(a => a.WorkingDevice.Device.Name.Contains(search)).OrderByDescending(a => a.Create_Date);
            if (ispaied != null) orders = orders.Where(a => a.Is_Paid == ispaied).OrderByDescending(a => a.Create_Date);
            int length = orders.Count();
            // return (await orders.ToListAsync(), length);
            return (await orders.Skip(0).Take(pageSize).Include(a => a.WorkingDevice).ThenInclude(a => a.Device)
               .Include(a => a.OrderDetails).ThenInclude(a => a.Product).ToListAsync(), length);

        }

        public async Task<List<Order>> GetTodayOrders()
        {
            return await _playStationDbContext.Orders.Where(w => w.Last_Modify_Date.Value.Date == DateTime.Now.Date && w.Is_Paid).ToListAsync();
        }

        public async Task<List<Order>> GetAllOrdersIncomesForADatePeriod(DateTime? from, DateTime? to)
        {
            var orders = _playStationDbContext.Orders.Where(a => a.Is_Paid);

            if (from.HasValue && to.HasValue)
                orders = orders.Where(a => a.Last_Modify_Date.Value.Date >= from.Value.Date && a.Last_Modify_Date.Value.Date <= to.Value.Date);
            else if (from.HasValue)
                orders = orders.Where(a => a.Last_Modify_Date.Value.Date >= from.Value.Date && a.Last_Modify_Date.Value.Date <= from.Value.Date.AddDays(30).Date);
            else if (to.HasValue)
                orders = orders.Where(a => a.Last_Modify_Date.Value.Date <= to.Value.Date && a.Last_Modify_Date.Value.Date >= to.Value.Date.AddDays(-30).Date);
            else
                orders = orders.Where(a => a.Last_Modify_Date.Value.Date >= DateTime.Now.Date.AddDays(-30).Date && a.Last_Modify_Date.Value.Date <= DateTime.Now.Date);
            return await orders.ToListAsync();
        }
    }
}
