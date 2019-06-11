using System;

namespace Strategy
{
    internal class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Едем на электричестве");
        }
    }
}