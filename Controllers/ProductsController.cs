using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Controllers.General;
using PlaystationProject.Dtos;
using PlaystationProject.Dtos.Products;
using PlaystationProject.Filters;
using PlaystationProject.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace PlaystationProject.Controllers
{
    public class ProductsController : ControllersBaseController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(string search, int pagesize = 20, int page = 1)
        {
            ViewBag.search = search;
            ViewBag.pagesize = pagesize;
            ViewBag.pagenumber = page;
            var res = await _productService.GetAllProducts(new GridSearchDto { PageNumber = page, PageSize = pagesize, SearchName = search });
            ViewBag.length = res.Data.Item2;
            ViewBag.pageCount = Math.Ceiling((double)res.Data.Item2 / pagesize);
            return View(res.Data.Item1);
        }

        public async Task<IActionResult> CreateProduct()
        {
            var res = await _productService.GetAllProductCategories();
            ViewBag.catagories = res.Data;
            
            return View();
        }
        
        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(AddEditProductDto addEditProductDto)
        {
            if (ModelState.IsValid)
            {
                var res = await _productService.AddEditProduct(addEditProductDto,base.CurrentUser.FullName);
                if (res.Success)
                    return Json(res);
            }
            return null;
        }
 
        public async Task<IActionResult> EditProduct(string id)
        {
            var resproduct = await _productService.GetProductById(Guid.Parse(id));
            var res = await _productService.GetAllProductCategories();
            ViewBag.catagories = res.Data;
            return View(resproduct.Data);
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> EditProduct(AddEditProductDto addEditProductDto)
        {
            var res = await _productService.AddEditProduct(addEditProductDto, base.CurrentUser.FullName);
            if (res.Success)
                return Json(res);
            return null;
        }

        [Authorization("ADMIN,SADMN")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var res = await _productService.DeleteProduct(Guid.Parse(id), base.CurrentUser.FullName);
                
                return Json(res);
           
        }

        public async Task<IActionResult> AddNewQuentityToProduct(string id)
        {
            var resproduct = await _productService.GetProductById(Guid.Parse(id));
            ViewBag.id = Guid.Parse(id);
            ViewBag.name = resproduct.Data.Name;
            return PartialView(new AddNewQuentityToProductDto());
        }

        [Authorization("ADMIN,SADMN")]
        [HttpPost]
        public async Task<IActionResult> AddNewQuentityToProduct(AddNewQuentityToProductDto addNewQuentity)
        {
            var res = await _productService.AddNewQuentityToProduct(addNewQuentity, base.CurrentUser.FullName);
           
            return Json(res);
        }

    }
}
