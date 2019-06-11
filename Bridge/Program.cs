﻿using System;
using Bridge.Languages;
using Bridge.Programmers;

namespace Bridge
{
    /// <summary>
    ///     Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким
    ///     образом,
    ///     чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.
    ///     Даже если мы отделим абстракцию от конкретных реализаций, то у нас все равно все наследуемые классы будут жестко
    ///     привязаны к интерфейсу,
    ///     определяемому в базовом абстрактном классе.Для преодоления жестких связей и служит паттерн Мост.
    ///     Когда использовать данный паттерн?
    ///     Когда надо избежать постоянной привязки абстракции к реализации
    ///     Когда наряду с реализацией надо изменять и абстракцию независимо друг от друга.
    ///     То есть изменения в абстракции не должно привести к изменениям в реализации
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Bridge";

            // создаем нового программиста, он работает с с++
            var freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.ReadKey();
        }
    }
}