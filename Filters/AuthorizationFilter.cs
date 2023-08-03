using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlaystationProject.Filters
{
    public class AuthorizationAttribute : TypeFilterAttribute
    {
        public AuthorizationAttribute(string userTypeCodes) : base(typeof(AuthorizationFilter))
        {
            Arguments = new object[] { new Claim("UserTypeCode", userTypeCodes) 
           
            };
        }
    }
    public class AuthorizationFilter : IAuthorizationFilter
    {

        readonly Claim _claim;

        public AuthorizationFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var roles = _claim.Value.Split(',').ToList();
            var hasClaim = context.HttpContext.User.Claims.Any(c =>  _claim.Type== c.Type && roles.Any(a=>a == c.Value));
            if (!hasClaim)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }


}

