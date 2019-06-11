using System;
using System.Threading;

namespace MultithreadSingleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Thread(() =>
            {
                var comp2 = new Computer();
                comp2.Os = OpSystem.GetInstance("Windows 10");
                Console.WriteLine(comp2.Os.Name);
            }).Start();

            var comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.Os.Name);

            Console.ReadKey();
        }

        //
        private class Computer
        {
            public OpSystem Os { get; set; }

            public void Launch(string osName)
            {
                Os = OpSystem.GetInstance(osName);
            }
        }

        private class OpSystem
        {
            private static OpSystem instance;

            private static readonly object syncRoot = new object();

            protected OpSystem(string name)
            {
                Name = name;
            }

            public string Name { get; }

            /// <summary>
            ///     Добавили блокировку для потоков для потокобезопасной реализации
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public static OpSystem GetInstance(string name)
            {
                if (instance == null)
                    lock (syncRoot)
                    {
                        instance = new OpSystem(name);
                    }

                return instance;
            }
        }
    }
}