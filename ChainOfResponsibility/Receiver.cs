namespace ChainOfResponsibility
{
    public class Receiver
    {
        public Receiver(bool bankTransfer, bool moneyTransfer, bool payPalTransfer)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
            PayPalTransfer = payPalTransfer;
        }

        // Банковские переводы
        public bool BankTransfer { get; set; }

        // Денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; set; }

        // Перевод через PayPal
        public bool PayPalTransfer { get; set; }
    }
}