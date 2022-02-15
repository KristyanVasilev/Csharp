using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;

        private int index;

        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
        }
    }
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public Library(params Book[] booksParam)
        {
            books = booksParam.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return new LibraryIterator(this.books);
            //return this.books.GetEnumerator();
            for (int index = 0; index < books.Count; index++)
            {
                yield return books[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
