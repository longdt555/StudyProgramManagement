using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
    public class UserSpecializedMapping : BaseCompact
    {
        public int UserId { get; set; }
        public int CourseFacultySpecializedId { get; set; }
    }
}
