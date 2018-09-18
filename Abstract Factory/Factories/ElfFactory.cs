using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{

    // Фабрика создания героя  Эльфа, летящего и с арбалетом
    class ElfFactory : HeroFactory
    {
        public override Weapon CreatWeapon()
        {
            return new Arbalet();
        }

        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
    }
}
