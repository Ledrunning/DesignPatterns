using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Weapons
{
    // Класс вида оружия - меч
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бью мечом!");
        }
    }
}
