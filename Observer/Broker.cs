using System;
using Observer.Interfaces;
using Observer.Stocks;

namespace Observer
{
    internal class Broker : IObserver
    {
        private IObservable _stock;

        public Broker(string name, IObservable obs)
        {
            Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public string Name { get; set; }

        public void Update(object obj)
        {
            var _stockInfo = (StockInfo) obj;

            if (_stockInfo.USD > 30)
                Console.WriteLine($"Брокер {Name} продает доллары; Курс доллара равен: {_stockInfo.USD}");
            else
                Console.WriteLine($"Брокер {Name} покупает доллары; Курс доллара равен: {_stockInfo.USD}");
        }

        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }
}