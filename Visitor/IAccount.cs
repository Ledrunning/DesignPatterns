using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {
        void VisitPersonAccount(Person account);
        void VisitCompanyAcount(Company account);
    }
}
