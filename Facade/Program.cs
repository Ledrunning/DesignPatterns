using System;

namespace Facade
{
    /// <summary>
    /// Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность системы с помощью
    /// предоставления упрощенного интерфейса для взаимодействия с ней.
    /// Когда использовать фасад?
    /// Когда имеется сложная система, и необходимо упростить с ней работу.Фасад позволит
    /// определить одну точку взаимодействия между клиентом и системой.
    /// Когда надо уменьшить количество зависимостей между клиентом и сложной системой. Фасадные объекты позволяют отделить,
    /// изолировать компоненты системы от клиента и развивать и работать с ними независимо.
    /// Когда нужно определить подсистемы компонентов в сложной системе. Создание фасадов для компонентов каждой отдельной
    /// подсистемы позволит упростить взаимодействие между ними и повысить их независимость друг от друга.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Facade";

            TextEditor textEditor = new TextEditor();
            Compiler compiler = new Compiler();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiler, clr);
            
            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.ReadKey();
        }
    }
}
