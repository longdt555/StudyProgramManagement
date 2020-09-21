using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.DTO
{
    public class UserRoleDTO:BaseCompactDTO
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
