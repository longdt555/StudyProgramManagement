using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lib.Data.DTO
{
    public class UserSpecializedMappingDTO : BaseCompactDTO
    {
        public int UserId { get; set; }
        [Column("CourseFaculty_Specialized_Id")]
        public int CourseFacultySpecializedId { get; set; }
    }
}
