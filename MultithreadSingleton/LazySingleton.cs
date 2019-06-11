using System;

namespace MultithreadSingleton
{
    internal class LazySingleton
    {
        private LazySingleton()
        {
            Name = Guid.NewGuid().ToString();
        }

        public string Name { get; }

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