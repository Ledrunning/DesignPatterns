using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Colleagues
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Notify(string message);

    }
}
