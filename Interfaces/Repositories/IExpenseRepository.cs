using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories.General;
using PlaystationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories
{
    public interface IExpenseRepository : IBaseRepository<Expense>
    {
        Task<(List<Expense>, int)> GetAllExpensesWithPagination(GridSearchDto paginationDto);
        Task<List<MasterData>> GetAllExpensesTypes();
        Task<Expense> GetExpenseById(Guid expenseId);
        Task<List<Expense>> GetTodayExpenses();
        Task<List<Expense>> GetAllExpensesForADatePeriod(DateTime? from, DateTime? to);
    }
}
