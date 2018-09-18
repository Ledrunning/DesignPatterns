using System;
using System.Threading;

//TODO доделай сиглтон!!!
namespace MultithreadSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                Computer comp2 = new Computer();
                comp2.Os = OpSystem.GetInstance("Windows 10");
                Console.WriteLine(comp2.Os.Name);

            })).Start();

            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.Os.Name);

            Console.ReadKey();
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

            private static object syncRoot = new Object();

            protected OpSystem(string name)
            {
                this.Name = name;
            }

            /// <summary>
            /// Добавили блокировку для потоков для потокобезопасной реализации
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public static OpSystem GetInstance(string name)
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new OpSystem(name);
                    }
                    
                }

                return instance;
            }
        }
    }
}
