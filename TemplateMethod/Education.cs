using System;

namespace TemplateMethod
{
    internal abstract class Education : Learning
    {
        public abstract void Enter();
        public abstract void Study();
        public abstract void GetDocument();

        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }

        // Запретили переопределение и использование в классах наследниках
        public sealed override void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
    }
}