using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
