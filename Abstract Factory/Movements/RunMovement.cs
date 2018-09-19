using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Movements
{
    // Класс движения - бег
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
