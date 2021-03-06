﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPM.DTO
{
    public class DocumentDTO : BaseCompactDTO
    {
        [Required]
        public string NameVI { get; set; }
        public string NameEN { get; set; }
        public string DescriptionVI { get; set; }
        public string DescriptionEN { get; set; }
        public int TypeId { get; set; }
    }
}
