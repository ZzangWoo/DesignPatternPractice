using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_FactoryPattern.PizzaCollection.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "시카고 스타일 딥 디쉬 치즈 피자";
            dough = "아주 두꺼운 크러스트 도우";
            sauce = "플럼토마토 소스";

            toppings.Add("치즈");
            toppings.Add("피클");
        }
    }
}
