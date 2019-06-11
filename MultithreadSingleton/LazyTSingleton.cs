using System;

namespace MultithreadSingleton
{
    internal class LazyTSingleton
    {
        private static readonly Lazy<LazyTSingleton> lazy = new Lazy<LazyTSingleton>(() => new LazyTSingleton());

        private LazyTSingleton()
        {
            Name = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public static LazyTSingleton GetInstance()
        {
            return lazy.Value;
        }
    }
}