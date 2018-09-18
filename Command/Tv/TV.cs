using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Tv
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }
}
