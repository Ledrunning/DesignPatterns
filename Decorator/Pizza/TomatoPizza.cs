using Decorator.AbstractPizza;

namespace Decorator.Pizza
{
    internal class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(AbstractPizza.Pizza pizza) : base(pizza.Name + ", с томатами", pizza)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}