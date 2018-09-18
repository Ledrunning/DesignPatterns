using System;

namespace SingleTon
{
    /// <summary>
    /// Паттерн Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует,
    /// что для определенного класса будет создан только один объект, а также предоставит
    /// к этому объекту точку доступа.
    /// Когда надо использовать Синглтон? Когда необходимо,
    /// чтобы для класса существовал только один экземпляр
    /// Синглтон позволяет создать объект только при его необходимости.Если объект не нужен,
    /// то он не будет создан.В этом отличие синглтона от глобальных переменных.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Singleton";

            Computer computer = new Computer();
            computer.Launch("Windows 10");

            Console.WriteLine(computer.Os.Name);

            // у нас не получится изменить ОС, так как объект уже создан  
            computer.Launch("asdasa");
            Console.WriteLine(computer.Os.Name);
           
            Console.ReadKey();
        }
    }

    //
    class Computer
    {
        public OpSystem Os { get; set; }

        public void Launch(string osName)
        {
            Os = OpSystem.GetInstance(osName);
        }
    }

    class OpSystem
    {
        private static OpSystem instance;

        public string Name { get; private set; }

        protected OpSystem(string name)
        {
            this.Name = name;
        }

        public static OpSystem GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new OpSystem(name);
            }

            return instance;
        }
    }


}
