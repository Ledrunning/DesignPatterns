using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{
    /// <summary>
    ///     Класс абстрактной фабрики создания бегущего героя с мечом
    /// </summary>
    internal class RunningWarriorFactory : HeroFactory
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