using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Incomes;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Interfaces.Services;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Services
{
    public class IncomesSevice : IIncomesSevice
    {
        private readonly IWorkingDeviceRepository _workingDeviceRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IExpenseRepository _expenseRepository;

        public IncomesSevice(IWorkingDeviceRepository workingDeviceRepository, IOrderRepository orderRepository, IExpenseRepository expenseRepository)
        {
            _workingDeviceRepository = workingDeviceRepository;
            _orderRepository = orderRepository;
            _expenseRepository = expenseRepository;
        }


        public async Task<ServiceResponse<TodayIncomesDto>> GetTodayIncomesAsync()
        {
            try
            {
                List<WorkingDevice> todayWorkingDevices = await _workingDeviceRepository.GetTodayWorkingDevices();
                List<Order> todayorders = await _orderRepository.GetTodayOrders();
                string todayIncomes = (todayWorkingDevices.Select(w => w.Total_Cost).Sum() + todayorders.Select(w => w.Total_Cost).Sum()).ToString();
                List<Expense> expenses = await _expenseRepository.GetTodayExpenses();
                string todayExpenses = expenses.Select(w => w.Cost).Sum().ToString();
                TodayIncomesDto todayIncomesDto = new TodayIncomesDto()
                {
                    Expenses = todayExpenses,
                    Incomes = todayIncomes
                };
                return new ServiceResponse<TodayIncomesDto> { Data = todayIncomesDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<TodayIncomesDto> { Data = new TodayIncomesDto(), Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<GetIncomesDto>>> GetTotalIncomes(DateTime? from, DateTime? to)
        {
            try
            {
                var allExpenses = await _expenseRepository.GetAllExpensesForADatePeriod(from, to);
                var allOrdersIncoms = await _orderRepository.GetAllOrdersIncomesForADatePeriod(from, to);
                var allWorkingDevicesIncoms = await _workingDeviceRepository.GetAllOrdersWorkingDevicesForADatePeriod(from, to);

                int daysCount = (from.HasValue && to.HasValue) ? (int)(to.Value.Date - from.Value.Date).TotalDays : 30;
                DateTime startDate= DateTime.Now.Date.AddDays(-30).Date;
                if ((from.HasValue && to.HasValue)|| from.HasValue) startDate=from.Value.Date;
                else if(to.HasValue) startDate = to.Value.Date.AddDays(-30).Date;
                var total = new GetIncomesDto
                {
                    Incomes = allOrdersIncoms.Select(a => a.Total_Cost).Sum() + allWorkingDevicesIncoms.Select(a => a.Total_Cost).Sum(),
                    Expenses = allExpenses.Select(a => a.Cost).Sum(),
                };
                total.TotalIncomes = total.Incomes - total.Expenses;
                var incomes = new List<GetIncomesDto>() { };
                for (int i = 0; i <= daysCount; i++)
                {
                    var obj = new GetIncomesDto()
                    {
                        DayDate = startDate.Date.ToString("yyyy/MM/dd"),
                        Expenses = allExpenses.Where(a => a.Create_Date.Date == startDate.Date).Select(a => a.Cost).Sum(),
                        Incomes = allOrdersIncoms.Where(a => a.Last_Modify_Date.Value.Date == startDate.Date).Select(a => a.Total_Cost).Sum()
                        + allWorkingDevicesIncoms.Where(a => a.Last_Modify_Date.Value.Date == startDate.Date).Select(a => a.Total_Cost).Sum()
                    };
                    obj.TotalIncomes = obj.Incomes - obj.Expenses;
                    incomes.Add(obj);
                    startDate = startDate.Date.AddDays(1).Date;
                }
                incomes.Add(total);
                return new ServiceResponse<List<GetIncomesDto>> { Data = incomes, Success = true };


            }
            catch (Exception ex)
            {

                return new ServiceResponse<List<GetIncomesDto>> { Data = new List<GetIncomesDto>(), Success = false, Message = "حدث خطأ" };

            }
        }

    }
}
