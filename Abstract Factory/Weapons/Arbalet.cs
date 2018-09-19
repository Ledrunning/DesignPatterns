using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Weapons
{
    // Класс вида оружия - арбалет
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляю из Арбалета");
        }
    }
}
