using AutoMapper;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Expenses;
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
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMasterDataRepository _masterDataRepository;
        private readonly IMapper _mapper;
        private readonly IHistoryRepository _historyRepository;

        public ExpenseService(IHistoryRepository historyRepository, IMapper mapper, IExpenseRepository expenseRepository, IUnitOfWork unitOfWork, IMasterDataRepository masterDataRepository)
        {
            _expenseRepository = expenseRepository;
            _unitOfWork = unitOfWork;
            _masterDataRepository = masterDataRepository;
            _mapper = mapper;
            _historyRepository = historyRepository;
        }

        public async Task<ServiceResponse<(List<GetAllExpensesDto>, int)>> GetAllExpensesAsync(GridSearchDto paginationDto)
        {
            try
            {
                (List<Expense> expenses, int length) = await _expenseRepository.GetAllExpensesWithPagination(paginationDto);
                if (expenses == null || length == 0) return new ServiceResponse<(List<GetAllExpensesDto>, int)> { Data = (new List<GetAllExpensesDto>(), 0), Success = false, Message = "لا يوجد بيانات" };
                List<GetAllExpensesDto> expensesDto = expenses.Select(e => new GetAllExpensesDto
                {
                    Id = e.Id,
                    Type = e.TypeMasterData.Category_Name,
                    Description = e.Description,
                    Cost = e.Cost.ToString(),
                    CreateDate = e.Create_Date.ToString("yyyy / MM / dd hh: mm tt"),
                }).ToList();
                return new ServiceResponse<(List<GetAllExpensesDto>, int)> { Data = (expensesDto, length), Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<(List<GetAllExpensesDto>, int)> { Data = (new List<GetAllExpensesDto>(), 0), Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> AddExpenseAsync(AddExpenseDto addExpenseDto, string userFullName)
        {
            try
            {
                Expense expense = new Expense()
                {
                    Type = addExpenseDto.Type,
                    Description = addExpenseDto.Description,
                    Cost = addExpenseDto.Cost
                };
                _expenseRepository.Create(expense);
                var historyDiscription = " لقد قام " + userFullName + " باضافة مصروف " + expense.Description;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم تتم العملية" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<EditExpenseDto>> GetExpenseByIdAsync(Guid deviceId)
        {
            try
            {
                Expense expense = await _expenseRepository.GetExpenseById(deviceId);
                if (expense == null) return new ServiceResponse<EditExpenseDto> { Data = null, Success = false, Message = "لا يوجد بيانات" };
                EditExpenseDto expenseDto = new EditExpenseDto()
                {
                    Id = expense.Id.ToString(),
                    Description = expense.Description,
                    Type = expense.Type,
                    Cost = expense.Cost
                };
                return new ServiceResponse<EditExpenseDto> { Data = expenseDto, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<EditExpenseDto> { Data = null, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> EditExpenseAsync(EditExpenseDto editExpenseDto, string userFullName)
        {
            try
            {
                Expense expnse = _expenseRepository.FindByID(Guid.Parse(editExpenseDto.Id));
                if (expnse == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لا يوجد بيانات" };
                _mapper.Map<EditExpenseDto, Expense>(editExpenseDto, expnse);
                var historyDiscription = " لقد قام " + userFullName + " بتعديل مصروف " + expnse.Description;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();

                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم تتم العملية" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<List<DropDown>>> GetAllExpensesTypesAsync()
        {
            try
            {
                List<MasterData> types = await _expenseRepository.GetAllExpensesTypes();
                if (types == null) return new ServiceResponse<List<DropDown>> { Data = new List<DropDown>(), Success = false, Message = "لا يوجد بيانات" };
                List<DropDown> typesList = types.Select(t => new DropDown
                {
                    Code = t.Code,
                    Name = t.Category_Name
                }).ToList();
                return new ServiceResponse<List<DropDown>> { Data = typesList, Success = true };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<DropDown>> { Data = new List<DropDown>(), Success = false, Message = "حدث خطأ" };
            }
        }

        public async Task<ServiceResponse<bool>> DeleteExpenseAsync(Guid expenseId, string userFullName)
        {
            try
            {
                Expense expense = _expenseRepository.FindByID(expenseId);
                if (expense == null) return new ServiceResponse<bool> { Data = false, Success = false, Message = "العنصر غير موجود للحذف" };
                _expenseRepository.Delete(expense);
                var historyDiscription = " لقد قام " + userFullName + " بحذف المصروف " + expense.Description;
                _historyRepository.Create(new Historie() { Description = historyDiscription });
                int result = await _unitOfWork.CommitAsync();
                if (result < 0) return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
                return new ServiceResponse<bool> { Data = true, Success = true, Message = "تمت العملية بنجاح" };
            }
            catch (Exception)
            {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = "لم يتم حذف العنصر لارتباطة بعناصر أخري" };
            }
        }
    }
}
