using System;
using State.ObjectStates;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "State";

            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.WriteLine("====================================");
            water = new Water(new GasWaterState());
            water.Heat();
            water.Frost();

            Console.WriteLine("====================================");

            water = new Water(new SolidWaterState());
            water.Heat();
            water.Frost();

            Console.ReadKey();
        }
    }
}
