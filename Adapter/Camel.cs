using System;
using Adapter.Interfaces;

namespace Adapter
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пустыне");
        }
    }
}