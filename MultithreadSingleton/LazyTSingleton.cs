using System;
using System.Collections.Generic;
using System.Text;

namespace MultithreadSingleton
{
    class LazyTSingleton
    {
        private static readonly Lazy<LazyTSingleton> lazy = new Lazy<LazyTSingleton>(() => new LazyTSingleton());

        public string Name { get; set; }

        private LazyTSingleton()
        {
            Name = System.Guid.NewGuid().ToString();
        }

        public static LazyTSingleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
