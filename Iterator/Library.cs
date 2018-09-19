using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book {Name = "Война и мир"},
                new Book {Name = "Отцы и дети"},
                new Book {Name = "Вишневый сад"}
            };
        }

        public IBookIterator CreateNumerator() => new LibraryNumerator(this);

        public int Count { get => books.Length; }

        public Book this[int index] { get => books[index]; }
    }
}
