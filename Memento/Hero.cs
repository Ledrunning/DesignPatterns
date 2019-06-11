using System;

namespace Memento
{
    /// <summary>
    ///     Originator
    /// </summary>
    public class Hero
    {
        private int _lives = 5;
        private int _patrons = 10;

        public void Shoot()
        {
            if (_patrons > 0)
            {
                _patrons--;
                Console.WriteLine($"Производим выстрел. Осталось {_patrons} патронов");
            }
            else
            {
                Console.WriteLine("Патронов больше нет");
            }
        }

        // Сохранение состояния
        public HeroMemento SaveState()
        {
            Console.WriteLine($"Сохранение игры. Параметры: {_patrons} патронов, {_lives} жизней");
            return new HeroMemento(_patrons, _lives);
        }

        // Восстановление состояния
        public void RestoreState(HeroMemento memento)
        {
            _patrons = memento.Patrons;
            _lives = memento.Lives;
            Console.WriteLine($"Восстановление игры. Параметры: {_patrons} патронов и {_lives} жизней");
        }
    }
}