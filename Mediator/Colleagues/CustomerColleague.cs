using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение заказчику: {message}");
        }
    }
}
