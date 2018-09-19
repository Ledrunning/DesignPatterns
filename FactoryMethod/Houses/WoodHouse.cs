using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Houses
{
    // Деревянный дом
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
