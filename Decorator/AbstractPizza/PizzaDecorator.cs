using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }
}
