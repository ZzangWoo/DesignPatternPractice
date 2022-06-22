using Chapter4_FactoryPattern.PizzaCollection;
using Chapter4_FactoryPattern.PizzaCollection.Chicago;
using Chapter4_FactoryPattern.PizzaCollection.NewYork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine($"주문한 {pizza.name} 나옴 \n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"주문한 {pizza.name} 나옴");
        }
    }
}