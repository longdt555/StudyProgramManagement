using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lib.Data.DTO
{
    public class CourseDTO : BaseCompactDTO
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
