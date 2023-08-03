using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Dtos;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Controllers
{
    public class HistoryController : Controller
    {
        private readonly IHistoryService _historyService;

        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        //[Authorization("ADMIN,SADMN")]
        public async Task<IActionResult> Index(DateTime? from, DateTime? to,string search, int pagesize = 50, int page = 1 )
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            ViewBag.pagenumber = page;
            ViewBag.from = from.HasValue ? from.Value.ToString("yyyy-MM-dd") : null;
            ViewBag.to = to.HasValue ? to.Value.ToString("yyyy-MM-dd") :null;
            var res = await _historyService.GetAllHistories(new GridSearchDto { PageNumber =page, PageSize = pagesize, SearchName = search,  From = from, To = to });
            ViewBag.length = res.Data.Item2;
            ViewBag.pageCount = Math.Ceiling((double)res.Data.Item2 / pagesize);
            return View(res.Data.Item1);
        }


    }
}
