using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{
    // Класс абстрактной фабрики
    // Здесь мы создаем два интсанса от движения и создания оружия
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreatWeapon();
    }
}
