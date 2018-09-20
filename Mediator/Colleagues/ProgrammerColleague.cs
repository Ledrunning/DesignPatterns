using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сщщбщение программисту: {message}");
        }
    }
}
