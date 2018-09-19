using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.Factories;
using Abstract_Factory.Movements;
using Abstract_Factory.Weapons;

namespace Abstract_Factory
{
    // Основной класс Героя
    class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

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
