using System;
using System.Collections.Generic;
using System.Text;

namespace SPM.DTO
{
    public class UserRoleDTO:BaseCompactDTO
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
