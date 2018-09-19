using System;

namespace Iterator
{
    /// <summary>
    /// Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа ко всем элементам составного объекта без раскрытия его внутренней структуры.
    /// Наверное, всем программистам, работающим с языком C#, приходилось иметь дело с циклом foreach, который перебирает объекты в массиве или коллекции.
    /// При этом встроенных классов коллекций существует множество, и каждая из них отличается по своей структуре и поведению.
    /// Ключевым моментом, который позволяет осуществить перебор коллекций с помощью foreach, является применения этими классами коллекций паттерна итератор,
    /// или проще говоря пары интерфейсов IEnumerable / IEnumerator.Интерфейс IEnumerator определяет функционал для перебора внутренних объектов в контейнере:
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Iterator";

            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.ReadKey();
        }

        interface IIBookIterator
        {
            bool HasNext();
            Book Next();
        }

        interface IBookNumerable
        {
            IIBookIterator CreateNumerator();
            int Count { get; }
            Book this[int index] { get; }
        }

        class Reader
        {
            public void SeeBooks(Library library)
            {
                IIBookIterator iterator = library.CreateNumerator();

                while (iterator.HasNext())
                {
                    Book book = iterator.Next();
                    Console.WriteLine(book.Name);
                }

            }
        }

        class Book
        {
            public string Name { get; set; }
        }

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

            public IIBookIterator CreateNumerator() => new LibraryNumerator(this);
           
            public int Count { get => books.Length; }

            public Book this[int index] { get => books[index]; }


    }

        class LibraryNumerator : IIBookIterator
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
}
