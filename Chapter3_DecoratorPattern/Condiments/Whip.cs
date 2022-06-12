﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            Description += beverage.Description + ", 휘핑크림";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.05;
        }
    }
}
