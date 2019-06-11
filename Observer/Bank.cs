using System;
using Observer.Interfaces;
using Observer.Stocks;

namespace Observer
{
    internal class Bank : IObserver
    {
        private readonly IObservable _stock;

        public Bank(string name, IObservable obs)
        {
            Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public string Name { get; set; }

        public void Update(object ob)
        {
            var stockinfo = ob as StockInfo;

            if (stockinfo.Euro > 40)
                Console.WriteLine($"Банк {Name} продает евро; Курс евро равен: {stockinfo.Euro}");
            else
                Console.WriteLine($"Банк {Name} покупает евро; Курс евро равен: {stockinfo.Euro}");
        }
    }
}