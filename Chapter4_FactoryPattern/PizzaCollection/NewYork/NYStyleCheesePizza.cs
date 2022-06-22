using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_FactoryPattern.PizzaCollection.NewYork
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "뉴욕 스타일 소스와 치즈 피자";
            dough = "씬 크러스트 도우";
            sauce = "마리나라 소스";

            toppings.Add("잘게 썬 레지아노 치즈");
        }
    }
}
