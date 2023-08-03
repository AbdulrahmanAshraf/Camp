using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Controllers.General;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Orders;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Controllers
{
    
    public class OrderController : ControllersBaseController
    {

        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IWorkingDeviceService _workingDeviceService;

        public OrderController(IOrderService orderService, IProductService productService, IWorkingDeviceService workingDeviceService)
        {
            _orderService = orderService;
            _productService = productService;
            _workingDeviceService = workingDeviceService;
        }
        
        public async Task<IActionResult> Index(string search, string PaidOrNot = "unpaid", int pagesize = 100)
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            bool? ispaied = null;
            if(PaidOrNot != null) ispaied = (PaidOrNot == "paid") ? true : false;
            var res = await _orderService.GetAllOrders(pagesize,search,ispaied);
            ViewBag.length = res.Data.Item2;
            ViewBag.PaidOrNot = PaidOrNot;
            var resCatgory = await _productService.GetAllProductCategories();
            var resDevices = await _workingDeviceService.GetAllWorkingDevices();
             ViewData["catagories"] = resCatgory.Success ? resCatgory.Data : new List<DropDown>();
             ViewData["orderdevices"] = resDevices.Success ? resDevices.Data : new List<DropDown>();
            return View(res.Data.Item1);
        }

        public async Task<IActionResult> CreateOrder()
        {
            var resCatgory = await _productService.GetAllProductCategories();
            var resDevices = await _workingDeviceService.GetAllWorkingDevices();
            ViewData["catagories"]= resCatgory.Success? resCatgory.Data:new List<DropDown>();
            ViewData["orderdevices"] = resDevices.Success ? resDevices.Data : new List<DropDown>();
            ViewBag.products = new List<DropDown>();
            return PartialView(new AddEditOrderDto() { Products=new List<AddProductToOrderDto>()});
        }

        public async Task<IActionResult> GetProductByCategory(string category)
        {
            if(category==null) return Json(new List<DropDown>());
            var res = await _productService.GetProductByCategory(category);
            return Json(res.Success ? res.Data : new List<GetProductByCategoryDto>());
        }

        public  IActionResult AddNewProductToOrder(string productName,Guid productId,decimal cost)
        {
            return PartialView("ProductDetail", new AddProductToOrderDto { ProductId = productId,Cost=cost ,ProductName=productName}) ;
        }

        [Authorization("ADMIN,SADMN,CACHR")]
        [HttpPost]
        public async Task<IActionResult> CreateEditOrder(AddEditOrderDto addEditOrderDto)
        {
            if (addEditOrderDto.Products == null) return Json(new ServiceResponse<int> { Success = false, Data = 0, Message = "يجب ادخال محتويات الطلب" });
            addEditOrderDto.Products = addEditOrderDto.Products.Where(a => a != null).ToList();
            if (addEditOrderDto.Products.Count == 0|| addEditOrderDto.Products.Any(a=>a.Quantity<=0)) return Json(new ServiceResponse<int> { Success = false,Data=0, Message = "يجب ادخال محتويات الطلب" });
           var res = await _orderService.AddEditOrder(addEditOrderDto, base.CurrentUser.FullName);
           return Json(res);
        }

        public async Task<IActionResult> EditOrder(string id)
        {
            var order = await _orderService.GetOrderForEdit(Guid.Parse(id));
            var resCatgory = await _productService.GetAllProductCategories();
            var resDevices = await _workingDeviceService.GetAllWorkingDevices(order.Data.WorkingDeviceId);
            ViewBag.catagories = resCatgory.Success ? resCatgory.Data : new List<DropDown>();
            ViewBag.devices = resDevices.Success ? resDevices.Data : new List<DropDown>();
            ViewBag.products = new List<DropDown>();
          
            return View(order.Data);
        }

        public async Task<IActionResult> PayOrder(string id)
        {
            var res = await _orderService.PayOrder(Guid.Parse(id), base.CurrentUser.FullName);
            return Json(res);
        }

    }
}
