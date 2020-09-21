using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lib.Data.DTO
{
    public class RoleDTO : BaseCompactDTO
    {
        [Required]
        public string NameVI { get; set; }
        public string NameEN { get; set; }
    }
}
