using System;

namespace Abstract_Factory.Movements
{
    /// <summary>
    ///     Класс движения полета
    /// </summary>
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}