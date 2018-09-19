using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Receiver
    {
        // Банковские переводы
        public bool BankTransfer { get; set; }

        // Денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; set; }

        // Перевод через PayPal
        public bool PayPalTransfer { get; set; }

        public Receiver(bool bankTransfer, bool moneyTransfer, bool payPalTransfer)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
            PayPalTransfer = payPalTransfer;
        }
    }


}
