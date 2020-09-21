using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.DTO
{
    public class SubjectBookMappingDTO : BaseCompactDTO
    {
        public int SubjectId { get; set; }
        public int BookId { get; set; }
    }
}