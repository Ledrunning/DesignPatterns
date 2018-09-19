using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    class OpSystem
    {
        private static OpSystem instance;

        public string Name { get; private set; }

        protected OpSystem(string name)
        {
            this.Name = name;
        }

        public static OpSystem GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new OpSystem(name);
            }

            return instance;
        }
    }
}
