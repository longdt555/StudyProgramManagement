using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
    public class CourseFacultyMapping : BaseCompact
    {
        public int CourseId { get; set; }
        public int FacultyId { get; set; }
    }
}
