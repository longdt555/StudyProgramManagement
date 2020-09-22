﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common.Entities
{
    public class SystemMasterData
    {
        public string NameVI { get; set; }
        public string NameEN { get; set; }
        public string DescriptionVI { get; set; }
        public string DescriptionEN { get; set; }
        public int GroupId { get; set; }
        public float Value { get; set; }
    }
}
