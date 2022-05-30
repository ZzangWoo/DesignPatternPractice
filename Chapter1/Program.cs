using Chapter1.Duck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chapter1.Duck.Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();
        }
    }
}
