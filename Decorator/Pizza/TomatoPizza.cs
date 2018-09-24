using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + ", с томатами", pizza)
        {

        }

        public override int GetCost() => pizza.GetCost() + 3;
    }
}
