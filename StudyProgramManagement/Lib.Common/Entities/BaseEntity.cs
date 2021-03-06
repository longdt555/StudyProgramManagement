﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
