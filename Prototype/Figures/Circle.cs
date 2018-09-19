using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Figures
{
    public class Circle : IFigure
    {
        private int _radius;

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
