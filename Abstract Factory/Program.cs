using System;
using Abstract_Factory.Factories;

namespace Abstract_Factory
{
    /// <summary>
    ///     Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных
    ///     объектов с определенными интерфейсами без указания конкретных типов данных объектов.
    ///     Когда использовать абстрактную фабрику:
    ///     Когда система не должна зависеть от способа создания и компоновки новых объектов
    ///     Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Абтрактная фабрика";

            //Создаем нашего героя c Арбалетом
            var elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            // Создаем нашего героя с бегающего мечом
            var runningWarrior = new Hero(new RunningWarriorFactory());
            runningWarrior.Hit();
            runningWarrior.Run();

            Console.ReadKey();
        }
    }
}