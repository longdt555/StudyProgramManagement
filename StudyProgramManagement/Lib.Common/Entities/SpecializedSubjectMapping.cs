using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
   public class SpecializedSubjectMapping : BaseCompact
    {
        public int SpecializedId { get; set; }
        public int SubjectId { get; set; }
    }
}
