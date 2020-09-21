using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lib.Data.DTO
{
    public class UserDTO : BaseDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string Password { get; set; }
        public int LanguageId { get; set; }
        public int StatusId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int CourseId { get; set; }
    }
}
