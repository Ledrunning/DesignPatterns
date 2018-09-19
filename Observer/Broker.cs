using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;
using Observer.Stocks;

namespace Observer
{
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
}
