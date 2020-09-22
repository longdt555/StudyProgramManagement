﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPM.DTO
{
    public class UserAddressDTO : BaseCompactDTO
    {
        public int UserId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StreetName { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
