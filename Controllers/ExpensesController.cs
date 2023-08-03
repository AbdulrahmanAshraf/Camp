using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Controllers.General;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Expenses;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PlaystationProject.Controllers
{
    public class ExpensesController : ControllersBaseController
    {
        private readonly IExpenseService _expenseService;

        public ExpensesController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        public async Task<IActionResult> Index(string type, DateTime? from, DateTime? to, string search, int pagesize = 20, int page = 1)
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            ViewBag.pagenumber = page;
            ViewBag.from = from.HasValue ? from.Value.ToString("yyyy-MM-dd") : null;
            ViewBag.to = to.HasValue ? to.Value.ToString("yyyy-MM-dd"):null;
            var res = await _expenseService.GetAllExpensesAsync(new GridSearchDto { PageNumber = page, PageSize = pagesize, SearchName = search, Type = type, From = from, To = to });
            ViewBag.length = res.Data.Item2;
            ViewBag.pageCount = Math.Ceiling((double)res.Data.Item2 / pagesize);
            return View(res.Data.Item1);
        }
        
        public async Task<IActionResult> Add()
        {
            var res = await _expenseService.GetAllExpensesTypesAsync();
            ViewBag.types = res.Data;
            return View();
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> Add(AddExpenseDto addExpenseDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _expenseService.AddExpenseAsync(addExpenseDto, base.CurrentUser.FullName);
                return Json(res);
            }
            return null;
        }

        public async Task<IActionResult> Edit(string id)
        {
            var expense = await _expenseService.GetExpenseByIdAsync(Guid.Parse(id));
            var res = await _expenseService.GetAllExpensesTypesAsync();
            ViewBag.types = res.Data;
            return View(expense.Data);
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> Edit(EditExpenseDto editExpenseDto)
        {
            var res = await _expenseService.EditExpenseAsync(editExpenseDto, base.CurrentUser.FullName);
            if (res.Success)
                return Json(res);
            return null;
        }

        [Authorization("ADMIN,SADMN")]
        public async Task<IActionResult> Delete(string id)
        {
            Guid deviceId = Guid.Parse(id);
            var res = await _expenseService.DeleteExpenseAsync(deviceId, base.CurrentUser.FullName);
            return Json(res);
        }

    }
}
