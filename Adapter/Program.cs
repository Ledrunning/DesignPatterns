using System;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        /// <summary>
        /// Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого.
        /// Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.
        /// Когда надо использовать Адаптер?
        /// Когда необходимо использовать имеющийся класс, но его интерфейс не соответствует потребностям
        /// Когда надо использовать уже существующий класс совместно с другими классами, интерфейсы которых не совместимы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Adapter";
           
            Driver driver = new Driver();
            Camel camel = new Camel();
            Auto auto = new Auto();
           
            driver.Travel(auto);

            // Adapter
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTransport);


            Console.ReadKey();
        }
    }
}
