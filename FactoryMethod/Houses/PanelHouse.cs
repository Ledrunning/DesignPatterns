using System;

namespace FactoryMethod.Houses
{
    /// <summary>
    ///     Панельный дом
    /// </summary>
    internal class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}