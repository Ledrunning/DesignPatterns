using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Едем на электричестве");
        }
    }
}
