using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{
    /// <summary>
    ///     Класс абстрактной фабрики  Здесь мы создаем два интсанса от движения и создания оружия
    /// </summary>
    internal abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreatWeapon();
    }
}