using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
    public class UserRole : BaseCompact
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
