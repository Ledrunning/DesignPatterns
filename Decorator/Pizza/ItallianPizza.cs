using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ItallianPizza : Pizza
    {

        public ItallianPizza() : base("Итальянская пица")
        {

        }

        public override int GetCost() => 10;
    }
}
