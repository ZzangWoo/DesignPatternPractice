﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
    }
}
