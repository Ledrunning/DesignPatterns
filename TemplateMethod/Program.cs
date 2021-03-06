﻿using System;

namespace TemplateMethod
{
    /// <summary>
    ///     Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить
    ///     отдельные шаги этого алгоритма без изменения его структуры.
    ///     Когда использовать шаблонный метод?
    ///     Когда планируется, что в будущем подклассы должны будут переопределять различные этапы алгоритма без изменения его
    ///     структуры
    ///     Когда в классах, реализующим схожий алгоритм, происходит дублирование кода.Вынесение общего кода в шаблонный метод
    ///     уменьшит его дублирование в подклассах.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Template method";

            var school = new School();
            var university = new University();

            // Весь цикл обучения в школе
            school.Learn();

            // Веь цикл обучения в университете
            university.Learn();

            Console.ReadKey();
        }
    }
}