using Iterator.Interfaces;

namespace Iterator
{
    internal class LibraryNumerator : IBookIterator
    {
        private readonly IBookNumerable _aggregate;
        private int _index;

        public LibraryNumerator(IBookNumerable bookNumerable)
        {
            _aggregate = bookNumerable;
        }

        public bool HasNext()
        {
            return _index < _aggregate.Count;
        }

        public Book Next()
        {
            return _aggregate[_index++];
        }
    }
}