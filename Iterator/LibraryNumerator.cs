using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class LibraryNumerator : IBookIterator
    {
        private IBookNumerable _aggregate;
        private int _index = 0;

        public LibraryNumerator(IBookNumerable bookNumerable)
        {
            _aggregate = bookNumerable;
        }

        public bool HasNext() => _index < _aggregate.Count;

        public Book Next() => _aggregate[_index++];

    }
}
