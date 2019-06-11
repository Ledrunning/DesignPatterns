using System;

namespace ChainOfResponsibility
{
    /// <summary>
    ///     Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет избежать
    ///     жесткой привязки отправителя запроса к получателю,
    ///     позволяя нескольким объектам обработать запрос. Все возможные обработчики запроса образуют цепочку, а сам запрос
    ///     перемещается по этой цепочке,
    ///     пока один из ее объектов не обработает запрос. Каждый объект при получении запроса выбирает, либо обработать
    ///     запрос, либо передать выполнение запроса следующему по цепочке.
    ///     Когда применяется цепочка обязанностей?
    ///     - Когда имеется более одного объекта, который может обработать определенный запрос
    ///     - Когда надо передать запрос на выполнение одному из нескольких объектов, точно не определяя, какому именно объекту
    ///     - Когда набор объектов задается динамически
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Chain Of Responsibility";

            // Выставляем флаги нужных нам вариантов переводов
            var receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHandler;

            bankPaymentHandler.Handle(receiver);

            receiver = new Receiver(false, true, false);
            paypalPaymentHandler.Handle(receiver);

            Console.ReadKey();
        }
    }
}