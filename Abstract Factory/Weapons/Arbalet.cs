using System;

namespace Abstract_Factory.Weapons
{
    /// <summary>
    ///     Класс вида оружия - арбалет
    /// </summary>
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляю из Арбалета");
        }
    }
}