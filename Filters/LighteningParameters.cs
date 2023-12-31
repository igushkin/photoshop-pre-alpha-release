﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class LighteningParameters : IParameters
    {
        [ParameterInfo(Name = "Ratio", MaxValue = 10, MinValue = 0, Increment = 0.1, DefaultValue = 1)]
        public double Coefficient { get; set; }
    }
}
