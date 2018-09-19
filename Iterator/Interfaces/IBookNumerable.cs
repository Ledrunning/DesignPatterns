using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }

}
