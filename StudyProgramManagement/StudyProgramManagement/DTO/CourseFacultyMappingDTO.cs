using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPM.DTO
{
    public class CourseFacultyMappingDTO : BaseCompactDTO
    {
        public int CourseId { get; set; }
        public int FacultyId { get; set; }
    }
}
