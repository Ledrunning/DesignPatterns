using System;

namespace Abstract_Factory
{
    /// <summary>
    /// Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных
    /// объектов с определенными интерфейсами без указания конкретных типов данных объектов.
    /// Когда использовать абстрактную фабрику: 
    /// Когда система не должна зависеть от способа создания и компоновки новых объектов
    /// Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
    /// </summary>
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Абтрактная фабрика";

            //Создаем нашего героя c Арбалетом
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            // Создаем нашего героя с бегающего мечом
            Hero runningWarrior = new Hero(new RunningWarrior());
            runningWarrior.Hit();
            runningWarrior.Run();

            Console.ReadKey();
        }
    }

    // Абстрактный класс - оружие
    abstract class Weapon
    {
        public abstract void Hit();
    }

    // Абстрактный класс движени
    abstract class Movement
    {
        public abstract void Move();
    }

    // Класс вида оружия - арбалет
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляю из Арбалета");
        }
    }

    // Класс вида оружия - меч
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бью мечом!");
        }
    }

    // Класс движения полета
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }

    // Класс движения - бег
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }

    // Класс абстрактной фабрики
    // Здесь мы создаем два интсанса от движения и создания оружия
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreatWeapon();
    }

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

    // Класс абстрактной фабрики создания бегущего героя с мечом
    class RunningWarrior : HeroFactory
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
