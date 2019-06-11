namespace Decorator.Pizza
{
    public class ItallianPizza : AbstractPizza.Pizza
    {
        public ItallianPizza() : base("Итальянская пица")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}