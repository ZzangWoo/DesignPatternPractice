using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_FactoryPattern.PizzaCollection
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;

        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"준비 중 : {name}");
            Console.WriteLine("도우를 돌리는 중....");
            Console.WriteLine("소스를 뿌리는 중....");
            Console.WriteLine("토핑을 올리는 중 : ");
            foreach (string topping in toppings)
            {
                Console.Write($"{topping}\t");
            }
            Console.WriteLine();
        }

        public void Bake()
        {
            Console.WriteLine("175도에서 25분 간 굽기");
        }

        public void Cut()
        {
            Console.WriteLine("피자를 사선으로 자르기");
        }

        public void Box()
        {
            Console.WriteLine("상자에 피자 담기");
        }
    }
}
