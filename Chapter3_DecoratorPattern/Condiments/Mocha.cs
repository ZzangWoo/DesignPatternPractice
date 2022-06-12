using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            Description += beverage.Description + ", 모카";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
