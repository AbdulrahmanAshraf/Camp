using Microsoft.EntityFrameworkCore;
using PlaystationProject.Dtos;
using PlaystationProject.Interfaces.Repositories;
using PlaystationProject.Models;
using PlaystationProject.Repositories.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Repositories
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(PlayStationDbContext playStationDb) : base(playStationDb)
        {

        }

        public async Task<(List<Expense>, int)> GetAllExpensesWithPagination(GridSearchDto paginationDto)
        {
            IQueryable<Expense> expenses = _playStationDbContext.Expenses.Include(m => m.TypeMasterData).OrderByDescending(a => a.Create_Date);
            if (!string.IsNullOrEmpty(paginationDto.SearchName))
                expenses = expenses.Where(a => a.Description.Contains(paginationDto.SearchName) || a.TypeMasterData.Category_Name.Contains(paginationDto.SearchName)).OrderByDescending(a => a.Create_Date);
            if (!string.IsNullOrEmpty(paginationDto.Type))
                expenses = expenses.Where(a => a.Type.Contains(paginationDto.Type)).OrderByDescending(a => a.Create_Date);
            if (paginationDto.From != null)
                expenses = expenses.Where(a => a.Create_Date >= paginationDto.From).OrderByDescending(a => a.Create_Date);
            if (paginationDto.To != null)
                expenses = expenses.Where(a => a.Create_Date <= paginationDto.To).OrderByDescending(a => a.Create_Date);
            int length = expenses.Count();
            if (paginationDto.PageNumber == -1) return (await expenses.ToListAsync(), length);
            return (await expenses.Skip((paginationDto.PageNumber - 1) * paginationDto.PageSize).Take(paginationDto.PageSize).Include(a => a.TypeMasterData).ToListAsync(), length);
        }

        public async Task<Expense> GetExpenseById(Guid expenseId)
        {
            return await _playStationDbContext.Expenses.Include(w => w.TypeMasterData).FirstOrDefaultAsync(d => d.Id == expenseId);
        }

        public async Task<List<MasterData>> GetAllExpensesTypes()
        {
            return await _playStationDbContext.MasterData.Where(m => m.Category_Parent_Id == Guid.Parse("6b514748-ccc4-4fc9-8d6e-6d692da8f306")).ToListAsync(); 
        }

        public async Task<List<Expense>> GetTodayExpenses()
        {
            return await _playStationDbContext.Expenses.Where(w => w.Create_Date.Date == DateTime.Now.Date).ToListAsync();
        }
        public async Task<List<Expense>> GetAllExpensesForADatePeriod(DateTime? from, DateTime? to)
        {
            var expenses = _playStationDbContext.Expenses.OrderByDescending(a=>a.Create_Date);

            if (from.HasValue&&to.HasValue)
                expenses = expenses.Where(a => a.Create_Date.Date >= from.Value.Date&& a.Create_Date.Date <= to.Value.Date).OrderByDescending(a => a.Create_Date);
            else if (from.HasValue)
                expenses = expenses.Where(a => a.Create_Date.Date >= from.Value.Date && a.Create_Date.Date <= from.Value.Date.AddDays(30).Date).OrderByDescending(a => a.Create_Date);
            else if (to.HasValue)
                expenses = expenses.Where(a => a.Create_Date.Date <= to.Value.Date && a.Create_Date.Date >= to.Value.Date.AddDays(-30).Date).OrderByDescending(a => a.Create_Date);
            else
                expenses = expenses.Where(a => a.Create_Date.Date >= DateTime.Now.Date.AddDays(-30).Date && a.Create_Date.Date <= DateTime.Now.Date).OrderByDescending(a => a.Create_Date);
            return await expenses.ToListAsync();
        }
    }
}
