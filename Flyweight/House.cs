using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public abstract class House
    {
        protected int stages; // Кл-во этажей

        public abstract void Build(double longtitude, double latitude);
    }
}
