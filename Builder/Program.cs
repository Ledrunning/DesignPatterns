using System;
using Builder.Builders;

namespace Builder
{
    /// <summary>
    ///     Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на
    ///     различные этапы.
    ///     Когда использовать паттерн Строитель?
    ///     - Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит
    ///     и как эти части связаны между собой
    ///     - Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Builder";

            // Объект пекаря
            var baker = new Baker();
            // Строитель для ржаного хлеба
            BreadBuilder breadBuilder = new RyeBreadBuilder();
            // Выпекаем
            var ryeBread = baker.Bake(breadBuilder);
            Console.WriteLine(ryeBread.ToString());

            // Строим пшеничный хлеб
            breadBuilder = new WheatBreadBuilder();
            var wheatBread = baker.Bake(breadBuilder);
            Console.WriteLine(wheatBread.ToString());

            Console.ReadKey();
        }
    }
}