using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();

            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }

        }
    }
}
