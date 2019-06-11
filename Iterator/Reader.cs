using System;

namespace Iterator
{
    internal class Reader
    {
        public void SeeBooks(Library library)
        {
            var iterator = library.CreateNumerator();

            while (iterator.HasNext())
            {
                var book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}