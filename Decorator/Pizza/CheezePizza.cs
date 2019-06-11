using Decorator.AbstractPizza;

namespace Decorator.Pizza
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(AbstractPizza.Pizza p)
            : base(p.Name + ", с сыром", p)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}