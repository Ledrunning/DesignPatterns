using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Observer
{
    /// <summary>
    /// Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования, который использует отношение "один ко многим". В этом отношении есть один наблюдаемый объект и множество наблюдателей.
    /// И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.
    /// Данный паттерн еще называют Publisher-Subscriber(издатель-подписчик), поскольку отношения издателя и подписчиков характеризуют
    /// действие данного паттерна: подписчики подписываются email-рассылку определенного сайта.Сайт-издатель с помощью email-рассылки уведомляет всех подписчиков о изменениях.
    /// А подписчики получают изменения и производят определенные действия: могут зайти на сайт, могут проигнорировать уведомления и т.д.
    /// Когда использовать паттерн Наблюдатель?
    /// - Когда система состоит из множества классов, объекты которых должны находиться в согласованных состояниях
    /// - Когда общая схема взаимодействия объектов предполагает две стороны: одна рассылает сообщения и является главным, другая получает сообщения
    /// и реагирует на них.Отделение логики обеих сторон позволяет их рассматривать независимо и использовать отдельно друга от друга.
    /// Когда существует один объект, рассылающий сообщения, и множество подписчиков, которые получают сообщения.
    /// При этом точное число подписчиков заранее неизвестно и процессе работы программы может изменяться.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Observer";

            Stock stock = new Stock();
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Василий Иванович", stock);
            
            // Имитация торгов
            stock.Market();

            broker.StopTrade();

            // имитация торгов
            stock.Market();

            Console.ReadKey();
        }
    }

    public interface IObserver
    {
        void Update(Object ob);
    }

    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    class Stock : IObservable
    {
        private StockInfo _stockInfo;
        private List<IObserver> _observers;

        public Stock()
        {
            _observers = new List<IObserver>();
            _stockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver observer)
        {
           _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        
        public void NotifyObservers()
        {
            foreach (var itemObserver in _observers)
            {
                itemObserver.Update(_stockInfo);
            }
        }

        public void Market()
        {
            Random random = new Random();
            _stockInfo.USD = random.Next(20, 40);
            _stockInfo.Euro = random.Next(30, 50);
            NotifyObservers();
        }
    }
  
    class StockInfo
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }

    class Broker : IObserver
    {
        public string Name { get; set; }
        private IObservable _stock;

        public Broker(string name, IObservable obs)
        {
            this.Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo _stockInfo = (StockInfo) obj;

            if (_stockInfo.USD > 30)
            {
                Console.WriteLine($"Брокер {this.Name} продает доллары; Курс доллара равен: {_stockInfo.USD}");
            }
            else
            {
                Console.WriteLine($"Брокер {this.Name} покупает доллары; Курс доллара равен: {_stockInfo.USD}");
            }
        }

        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }

    class Bank : IObserver
    {
        public string Name { get; set; }
        private IObservable _stock;

        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stockinfo = ob as StockInfo;

            if(stockinfo.Euro > 40)
                Console.WriteLine($"Банк {this.Name} продает евро; Курс евро равен: {stockinfo.Euro}");
            else 
                Console.WriteLine($"Банк {this.Name} покупает евро; Курс евро равен: {stockinfo.Euro}");
        }
    }
}
