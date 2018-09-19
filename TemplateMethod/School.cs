using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class School : Education
    {
        // Первый класс
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        // Обучение
        public override void Study()
        {
            Console.WriteLine("Посещаем уроки и делаем домашние задания");
        }

        // Получение аттестата
        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }

    }
}
