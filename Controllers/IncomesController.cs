using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Dtos.Incomes;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Controllers
{
    public class IncomesController : Controller
    {
        private readonly IIncomesSevice _incomesSevice;

        public IncomesController(IIncomesSevice incomesSevice)
        {
            _incomesSevice = incomesSevice;
        }

        public async Task<IActionResult> Index(DateTime? from, DateTime? to)
        {
            ViewBag.from = from.HasValue ? from.Value.ToString("yyyy-MM-dd") : null;
            ViewBag.to = to.HasValue ? to.Value.ToString("yyyy-MM-dd") :null;
            if (to.HasValue && from.HasValue)
            {
                if ((to.Value.Date - from.Value.Date).TotalDays > 30) return View(new List<GetIncomesDto>());
            }
            var res = await _incomesSevice.GetTotalIncomes(from, to);
            return View(res.Data);
        }


        [HttpGet]
        public async Task<IActionResult> GetTodayIncomes()
        {
            var res = await _incomesSevice.GetTodayIncomesAsync();
            return Json(res);
        }
    }
}
