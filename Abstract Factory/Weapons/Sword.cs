using System;

namespace Abstract_Factory.Weapons
{
    /// <summary>
    ///     Класс вида оружия - меч
    /// </summary>
    internal class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бью мечом!");
        }
    }
}