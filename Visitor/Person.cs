using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAccount(this);
        }
    }
}
