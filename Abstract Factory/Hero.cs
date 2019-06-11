using Abstract_Factory.Factories;
using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory
{
    /// <summary>
    ///     Основной класс Героя
    /// </summary>
    internal class Hero
    {
        private readonly Movement _movement;
        private readonly Weapon _weapon;

        //  В конструктор передаем фабрику героев
        public Hero(HeroFactory factory)
        {
            _weapon = factory.CreatWeapon();
            _movement = factory.CreateMovement();
        }

        // Вид движения
        public void Run()
        {
            _movement.Move();
        }

        // Способ нападния

        public void Hit()
        {
            _weapon.Hit();
        }
    }
}