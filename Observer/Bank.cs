using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;
using Observer.Stocks;

namespace Observer
{
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

            if (stockinfo.Euro > 40)
                Console.WriteLine($"Банк {this.Name} продает евро; Курс евро равен: {stockinfo.Euro}");
            else
                Console.WriteLine($"Банк {this.Name} покупает евро; Курс евро равен: {stockinfo.Euro}");
        }
    }
}
