using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Houses;

namespace FactoryMethod.Developers
{
    // Строительная компания
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        public abstract House Create();
    }
}
