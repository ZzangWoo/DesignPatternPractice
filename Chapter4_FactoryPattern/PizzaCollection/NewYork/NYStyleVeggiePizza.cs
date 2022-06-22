using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_FactoryPattern.PizzaCollection.NewYork
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "뉴욕 스타일 맛있는 야채 피자";
            dough = "씬 도우";
            sauce = "맛있는 소스";

            toppings.Add("파프리카");
            toppings.Add("맛있는 채소");
        }
    }
}
