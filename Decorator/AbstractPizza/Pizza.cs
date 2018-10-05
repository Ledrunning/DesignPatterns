using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public abstract int GetCost();

        public Pizza(string name)
        {
            Name = name;
        }
    }
}
