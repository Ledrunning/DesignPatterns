using System;

namespace FactoryMethod.Houses
{
    /// <summary>
    ///     Деревянный дом
    /// </summary>
    internal class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}