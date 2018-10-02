using System;
using System.Collections.Generic;
using System.Text;
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
