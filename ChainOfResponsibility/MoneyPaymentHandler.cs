using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Выполняется перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
