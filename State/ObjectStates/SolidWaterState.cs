using System;
using System.Collections.Generic;
using System.Text;

namespace State.ObjectStates
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед жидкость");
            water.State = new SolidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
}
