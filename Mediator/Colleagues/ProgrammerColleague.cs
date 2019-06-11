using System;

namespace Mediator.Colleagues
{
    internal class ProgrammerColleague : Colleague
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