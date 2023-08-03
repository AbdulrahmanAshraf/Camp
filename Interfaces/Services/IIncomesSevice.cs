using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Incomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
    public interface IIncomesSevice
    {
        Task<ServiceResponse<TodayIncomesDto>> GetTodayIncomesAsync();
        Task<ServiceResponse<List<GetIncomesDto>>> GetTotalIncomes(DateTime? from, DateTime? to);
    }
}
