using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Movements
{
    // Класс движения полета
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
