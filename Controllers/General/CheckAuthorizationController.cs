using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Controllers.General
{

    public class CheckAuthorizationController : ControllersBaseController
    {

        [Authorize]
        public IActionResult GetCanViewLinks()
        {
            if (base.CurrentUser.UserType == UserTypeEnum.SADMN.ToString())
            {
                return Json(new { showProducts = true, showOrders = true, showDevices = true, workingDevices = true, showExpenses = true, showHistory = true,showIncomes=true });

            }
            if (base.CurrentUser.UserType == UserTypeEnum.ADMIN.ToString())
            {
                return Json(new { showProducts = true, showOrders = true, showDevices = true, workingDevices = true, showExpenses = true, showHistory = true, showIncomes = false });

            }
            else if (base.CurrentUser.UserType == UserTypeEnum.CACHR.ToString())
            {
                return Json(new { showProducts = false, showOrders = true, showDevices = false, workingDevices = true, showExpenses = false, showHistory = false , showIncomes = false });
            }

            return Json(new { showProducts = false, showOrders = false, showDevices = false, workingDevices = false, showExpenses = false, showHistory = false,showIncomes = false });

        }
    }
}
