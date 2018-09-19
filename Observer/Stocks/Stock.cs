using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;


namespace Observer.Stocks
{
    public class Stock : IObservable
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
}
