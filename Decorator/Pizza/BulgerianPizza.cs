namespace Decorator.Pizza
{
    internal class BulgerianPizza : AbstractPizza.Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }
}