using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Services
{
    public interface IExpenseService
    {
        Task<ServiceResponse<(List<GetAllExpensesDto>, int)>> GetAllExpensesAsync(GridSearchDto paginationDto);
        Task<ServiceResponse<bool>> AddExpenseAsync(AddExpenseDto addExpenseDto, string userFullName);
        Task<ServiceResponse<List<DropDown>>> GetAllExpensesTypesAsync();
        Task<ServiceResponse<bool>> DeleteExpenseAsync(Guid expenseId, string userFullName);
        Task<ServiceResponse<bool>> EditExpenseAsync(EditExpenseDto editExpenseDto, string userFullName);
        Task<ServiceResponse<EditExpenseDto>> GetExpenseByIdAsync(Guid deviceId);
    }
}
