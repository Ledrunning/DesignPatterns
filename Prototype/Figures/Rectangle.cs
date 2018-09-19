using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Figures
{
    public class Rectangle : IFigure
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public IFigure Clone()
        {
            return new Rectangle(_width, _height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Прямоугольник длиной {_height} и шириной {_width}");
        }
    }
}
