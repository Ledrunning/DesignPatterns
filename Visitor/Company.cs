using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
           visitor.VisitCompanyAccount(this);
        }
    }
}
