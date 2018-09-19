using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
