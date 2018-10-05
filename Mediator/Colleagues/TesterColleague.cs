using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение тестеру: {message}");
        }
    }
}
