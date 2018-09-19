using System;
using Prototype.Figures;

namespace Prototype
{
    /// <summary>
    /// Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов.
    /// То есть по сути данный паттерн предлагает технику клонирования объектов.
    /// Когда использовать Прототип?
    /// - Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения
    /// - Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов-продуктов
    /// из параллельной иерархии классов(как это делается, например, при использовании паттерна Абстрактная фабрика)
    /// - Когда клонирование объекта является более предпочтительным вариантом нежели его создание
    /// и инициализация с помощью конструктора.Особенно когда известно, что объект может принимать небольшое ограниченное число возможных состояний.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Prototype";

            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.ReadKey();
        }
    }
}
