using System;
using System.Collections.Generic;
using System.Text;

namespace SPM.DTO
{
    public class SpecializedSubjectMappingDTO : BaseCompactDTO
    {
        public int SpecializedId { get; set; }
        public int SubjectId { get; set; }
    }
}
