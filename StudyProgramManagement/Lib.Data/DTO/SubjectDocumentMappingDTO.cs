﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Data.DTO
{
    public class SubjectDocumentMappingDTO : BaseCompactDTO
    {
        public int SubjectId { get; set; }
        public int DocumentId { get; set; }
    }
}
