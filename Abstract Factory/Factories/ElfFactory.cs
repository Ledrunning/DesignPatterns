using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory.Factories
{
    /// <summary>
    ///     Фабрика создания героя  Эльфа, летящего и с арбалетом
    /// </summary>
    internal class ElfFactory : HeroFactory
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