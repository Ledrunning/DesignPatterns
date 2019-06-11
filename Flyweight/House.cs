namespace Flyweight
{
    public abstract class House
    {
        protected int stages; // Кл-во этажей

        public abstract void Build(double longtitude, double latitude);
    }
}