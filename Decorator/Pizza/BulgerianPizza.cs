using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        {

        }

        public override int GetCost() => 8;

    }
}
