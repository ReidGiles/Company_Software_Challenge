﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class CalculateArea : PerformCalculation
    {
        public double Execute(double length, double width, double height)
        {
            return height * width;
        }
    }
}