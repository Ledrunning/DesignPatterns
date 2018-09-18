using System;

namespace Strategy
{
    /// <summary>
    /// Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет набор алгоритмов,
    /// инкапсулирует каждый из них и обеспечивает их взаимозаменяемость. В зависимости от ситуации мы можем легко заменить один
    /// используемый алгоритм другим. При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.
    /// Когда использовать стратегию?
    /// - Когда есть несколько родственных классов, которые отличаются поведением.Можно задать один основной класс, а разные варианты
    /// поведения вынести в отдельные классы и при необходимости их применять
    /// - Когда необходимо обеспечить выбор из нескольких вариантов алгоритмов, которые можно легко менять в зависимости от условий
    /// - Когда необходимо менять поведение объектов на стадии выполнения программы
    /// - Когда класс, применяющий определенную функциональность, ничего не должен знать о ее реализации
    /// -Формально паттерн Стратегия можно выразить следующей схемой UML:
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Strategy";

            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();

            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadKey();
        }
    }

    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Едем на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Едем на электричестве");
        }
    }

    class Car
    {
        protected int passengers;
        protected string model;
        
        public IMovable Movable { private get; set; }

        public Car(int num, string model, IMovable move)
        {
            passengers = num;
            this.model = model;
            Movable = move;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
