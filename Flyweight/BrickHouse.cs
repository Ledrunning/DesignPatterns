using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double longtitude, double latitude)
        {
            Console.WriteLine(
                $"Построен кирпичный дом из 5 этажей; координаты: {latitude} широты и {longtitude} долготы");
        }
    }
}
