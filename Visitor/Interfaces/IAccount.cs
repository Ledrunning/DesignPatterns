using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
