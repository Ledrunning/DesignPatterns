using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;

namespace Adapter
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
