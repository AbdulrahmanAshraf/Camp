using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaystationProject.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlaystationProject.Controllers.General
{

    public class ControllersBaseController : Controller
    {
        public UserDto CurrentUser
        {
            get
            {
                return new UserDto()
                {
                    Id = new Guid(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                    UserName = User.FindFirst(ClaimTypes.Name).Value,
                    FullName = User.FindFirst(ClaimTypes.GivenName).Value,
                    UserType = User.FindFirst("UserTypeCode").Value
                };
            }
        }

    }
}


