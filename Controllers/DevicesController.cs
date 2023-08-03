using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlaystationProject.Controllers.General;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Devices;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PlaystationProject.Controllers
{
    public class DevicesController : ControllersBaseController
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string search, int pagesize = 20, int page = 1)
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            ViewBag.pagenumber = page;
            var res = await _deviceService.GetAllDevicesAsync(new GridSearchDto { PageNumber = page, PageSize = pagesize, SearchName = search });
            ViewBag.length = res.Data.Item2;
            ViewBag.pageCount = Math.Ceiling((double)res.Data.Item2 / pagesize);
            return View(res.Data.Item1);
        }

        public async Task<IActionResult> Add()
        {
            var res = await _deviceService.GetAllDeviceTypesAsync();
            ViewBag.types = res.Data;
            return View();
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> Add(AddDeviceDto addDeviceDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _deviceService.AddDeviceAsync(addDeviceDto, base.CurrentUser.FullName);
                return Json(res);
            }
            return null;
        }

        public async Task<IActionResult> Edit(string id)
        {
            var device = await _deviceService.GetDeviceByIdAsync(Guid.Parse(id));
            var res = await _deviceService.GetAllDeviceTypesAsync();
            ViewBag.types = res.Data;
            return View(device.Data);
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> Edit(EditDeviceDto editDeviceDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _deviceService.EditDeviceAsync(editDeviceDto, base.CurrentUser.FullName);
                if (res.Success)
                    return Json(res);
                return null;
            }
            return null;
        }

        [Authorization("ADMIN,SADMN")]
        public async Task<IActionResult> Delete(string id)
        {
            Guid deviceId = Guid.Parse(id);
            var res = await _deviceService.DeleteDeviceAsync(deviceId, base.CurrentUser.FullName);
            return Json(res);
        }
    }
}
