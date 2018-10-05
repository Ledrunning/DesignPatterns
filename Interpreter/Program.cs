using System;

namespace Interpreter
{
    /// <summary>
    /// Паттерн Интерпретатор (Interpreter) определяет представление грамматики для заданного языка и интерпретатор предложений этого языка. Как правило,
    /// данный шаблон проектирования применяется для часто повторяющихся операций.
    /// Хотя паттерн требует понимания теории формальных языков и грамматик, на самом деле он не так сложен в понимании.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Interpreter";

            Context context = new Context();

            // Набор переменных
            int x = 5;
            int y = 8;
            int z = 2;

            // Добавляем переменные в контекст
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            // Создаем объект для вычисления выражения х + у - z
            IExpression expression = new SubtractExpression(new AddExpression(new NumberExpression("x"), new NumberExpression("y")), new NumberExpression("z"));

            int result = expression.Interpret(context);
            Console.WriteLine($"результат: {result}");

            Console.ReadKey();
        }
    }
}
