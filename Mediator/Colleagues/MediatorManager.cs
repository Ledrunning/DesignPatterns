using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class MediatorManager : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            // Если отправитель - заказчик, значит есть новый заказ
            // отправляем сообщение программисту - выполнить заказ
            if(Customer == colleague)
                Programmer.Notify(message);
            // Если отправитель - программист, то можно приступать к тестированию
            // отправляем сообщение тестеру
            else if(Programmer == colleague)
                Tester.Notify(message);
            // Если отправитель - тест, значит продукт готов
            // отправляем сообщение заказчику
            else if(Tester == colleague)
                Customer.Notify(message);
        }
    }
}
