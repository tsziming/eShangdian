﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Models
{
    public class AttributeDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public Attribute Attribute { get; set; }
        public string Name { get; set; }
    }
}
