using System;

namespace Abstract_Factory.Movements
{
    /// <summary>
    ///     Класс движения - бег
    /// </summary>
    internal class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}