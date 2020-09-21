using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.DTO
{
    public class BaseModel
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UpdatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

    }
}
