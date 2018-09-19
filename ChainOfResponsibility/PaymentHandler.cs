using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
