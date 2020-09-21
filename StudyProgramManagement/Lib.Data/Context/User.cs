using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.Context
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int LanguageId { get; set; }
        public int StatusId { get; set; }
        public string Email { get; set; }

    }
}
