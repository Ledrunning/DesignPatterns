using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MultithreadSingleton
{
    class LazySingleton
    {
        public string Name { get; private set; }
        private LazySingleton()
        {
            Name = System.Guid.NewGuid().ToString();
        }

        public static LazySingleton GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
