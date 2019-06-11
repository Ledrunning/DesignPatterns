using Iterator.Interfaces;

namespace Iterator
{
    internal class Library : IBookNumerable
    {
        private readonly Book[] books;

        public Library()
        {
            books = new[]
            {
                new Book {Name = "Война и мир"},
                new Book {Name = "Отцы и дети"},
                new Book {Name = "Вишневый сад"}
            };
        }

        public int Count => books.Length;

        public Book this[int index] => books[index];

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}