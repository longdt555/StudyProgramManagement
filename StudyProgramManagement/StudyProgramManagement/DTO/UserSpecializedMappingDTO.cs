using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPM.DTO
{
    public class UserSpecializedMappingDTO : BaseCompactDTO
    {
        public int UserId { get; set; }
        public int CourseFacultySpecializedId { get; set; }
    }
}
