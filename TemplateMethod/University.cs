using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class University : Education
    {
        // Поступление в Университет
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        // Обучение
        public override void Study()
        {
            Console.WriteLine("Посещаем лекции и проходим практику");
        }

        // Сдаем выпускные экзамены
        public void PassExams()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диоплом о высшем образовании");
        }

    }
}
