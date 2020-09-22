using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace SPM.Authorization
{
    public static class AuthorizationHelper
    {
        public static bool HasPermission(this ControllerBase controller, string permission)
        {
            // some implementation 
            return controller.HttpContext.User.Claims.Any(c => c.Type.ToLower() == MyClaimTypes.Permissions.ToLower() && c.Value.ToLower().Contains(permission.ToLower()));
        }

        public static bool HasRole(this ControllerBase controller, string role)
        {
            // some implementation 
            return controller.HttpContext.User.Claims.Any(c => c.Type.ToLower() == ClaimTypes.Role.ToLower() && c.Value.ToLower().Contains(role.ToLower()));
        }
    }
}