using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            Description = beverage.Description + ", 두유";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
