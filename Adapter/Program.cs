using System;
using Adapter.Interfaces;

namespace Adapter
{
    internal class Program
    {
        /// <summary>
        ///     Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
        ///     Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.
        ///     Когда надо использовать Адаптер?
        ///     Когда необходимо использовать имеющийся класс, но его интерфейс не соответствует потребностям
        ///     Когда надо использовать уже существующий класс совместно с другими классами, интерфейсы которых не совместимы
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Adapter";

            var driver = new Driver();
            var camel = new Camel();
            var auto = new Auto();

            driver.Travel(auto);

            // Adapter
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTransport);

            Console.ReadKey();
        }
    }
}