using System;

namespace Prototype.Figures
{
    public class Circle : IFigure
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public IFigure Clone()
        {
            return new Circle(_radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Круг радиусом {_radius}");
        }
    }
}