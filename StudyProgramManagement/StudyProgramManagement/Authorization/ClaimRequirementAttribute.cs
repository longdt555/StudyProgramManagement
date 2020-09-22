using Lib.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPM.Authorization
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public ClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // BY PASS BY ADMIN ROLE
            if (context.HttpContext.User.Claims.Any(c => c.Type.ToLower() == ClaimTypes.Role.ToLower() && c.Value.ToLower().Contains(Role.Admin.ToLower()))) return;
            // START CHECKING ROLES HERE
            if (!context.HttpContext.User.Claims.Any(c => c.Type.ToLower() == _claim.Type.ToLower() && c.Value.ToLower().Contains(_claim.Value.ToLower()))) context.Result = new ForbidResult();
        }
    }
}
