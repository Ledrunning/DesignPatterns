using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Houses;

namespace FactoryMethod.Developers
{
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
