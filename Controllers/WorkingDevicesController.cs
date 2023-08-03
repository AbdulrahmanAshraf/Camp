using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Controllers.General;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
using PlaystationProject.Dtos.WorkingDevices;
using PlaystationProject.Enums;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PlaystationProject.Controllers
{
    public class WorkingDevicesController : ControllersBaseController
    {
        private readonly IDeviceService _deviceService;
        private readonly IWorkingDeviceService _workingDeviceService;
        private readonly IProductService _productService;
        public WorkingDevicesController(IProductService productService,IDeviceService deviceService, IWorkingDeviceService workingDeviceService)
        {
            _deviceService = deviceService;
            _workingDeviceService = workingDeviceService;
            _productService = productService;
        }

        public async Task<IActionResult> Index(string search, string isOpen= "open",  int pagesize = 50, int page = 1)
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            ViewBag.pagenumber = page;
            var resCatgory = await _productService.GetAllProductCategories();
            var resDevices = await _workingDeviceService.GetAllWorkingDevices();
            ViewData["data"] = new GetWorkingDeviceDetailsDto() { Periods = new List<WorkingDevicePeeriodsDto>() };
            ViewBag.isOpen = isOpen;
            ViewData["devices"] = (await _deviceService.GetDevicesDropDownAsync()).Data;
            ViewData["catagories"] = resCatgory.Success ? resCatgory.Data : new List<DropDown>();
            ViewData["orderdevices"] = resDevices.Success ? resDevices.Data : new List<DropDown>();
            bool? IsOpen = null;
            if (isOpen != null) IsOpen = (isOpen == "open") ? true : false;
            var res = await _workingDeviceService.GetAllWorkingDevicesAsync(new GridSearchDto { PageNumber =page, PageSize = pagesize, SearchName = search }, IsOpen);
            ViewBag.length = res.Data.Item2;
            return View(res.Data.Item1);
        }

        #region Run Device
        [HttpGet]
        public async Task<IActionResult> RunDevice()
        {
            var res = await _deviceService.GetDevicesDropDownAsync();
            ViewBag.devices = res.Data;
            return PartialView("_RunDevice");
        }

        [Authorization("ADMIN,SADMN,CACHR")]
        [HttpPost]
        public async Task<IActionResult> RunDevice(RunDeviceDto runDeviceDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _workingDeviceService.RunDeviceAsync(runDeviceDto, base.CurrentUser.FullName);
                return Json(res);
            }
            return null;
        }
        #endregion

        #region Add Period
        [Authorization("ADMIN,SADMN,CACHR")]
        [HttpPost]
        public async Task<IActionResult> AddPeriod(AddPeriodDto addPeriodDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _workingDeviceService.AddPeriodToRunningDeviceAsync(addPeriodDto, base.CurrentUser.FullName);
                return Json(res);
            }
            return null;
        }
        #endregion

        #region Close Device
        [HttpGet]
        public async Task<IActionResult> GetWorkingDeviceToClose([FromQuery] Guid Id)
        {
            if (ModelState.IsValid)
            {
                var res = await _workingDeviceService.GetWorkingDeviceDetailsToCloseAsync(Id);
                return Json( res.Data);
            }
            return null;
        }

        [Authorization("ADMIN,SADMN,CACHR")]
        [HttpPost]
        public async Task<IActionResult> CloseDeviceWorking(CloseDeviceDto closeDeviceDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _workingDeviceService.CloseDeviceAsync(closeDeviceDto, base.CurrentUser.FullName);
                return Json(res);
            }
            return null;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetWorkingDeviceDetails([FromQuery] Guid Id)
        {
            if (ModelState.IsValid)
            {
                var res = await _workingDeviceService.GetWorkingDeviceDetailsAsync(Id);
                return Json(res.Data);
            }
            return null;
        }
    }
}
