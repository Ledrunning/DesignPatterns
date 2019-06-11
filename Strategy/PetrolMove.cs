using System;

namespace Strategy
{
    internal class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Едем на бензине");
        }
    }
}