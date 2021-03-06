﻿using System;

namespace ChainOfResponsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
                Console.WriteLine("Выполняется банковский перевод");
            else if (Successor != null) Successor.Handle(receiver);
        }
    }
}