using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{
    // Класс абстрактной фабрики создания бегущего героя с мечом
    class RunningWarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreatWeapon()
        {
            return new Sword();
        }
    }
}
