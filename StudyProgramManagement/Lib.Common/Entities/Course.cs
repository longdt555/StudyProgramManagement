using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
   public class Course : BaseCompact
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
