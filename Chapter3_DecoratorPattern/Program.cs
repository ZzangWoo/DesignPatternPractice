using Chapter3_DecoratorPattern.Beverages;
using Chapter3_DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} -> ${beverage.Cost()}");

            Console.WriteLine();

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.Description} -> ${beverage2.Cost()}");
        }
    }
}
