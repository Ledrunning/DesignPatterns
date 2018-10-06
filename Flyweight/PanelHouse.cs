using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 16;
        }

        public override void Build(double longtitude, double latitude)
        {
            Console.WriteLine($"Построен панельный дом из 16 этажей; координаты: {latitude} широты и {longtitude} долготы");
        }
    }
}
