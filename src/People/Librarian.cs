using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Librarian : Person
    {
        private Library _libraryInstance;

        public Librarian(string name, string address)
            : base(name, address)
        {
            _libraryInstance = Library.Instance;
        }

        public void AddBook(Book book)
        {
            _libraryInstance.AddBook(book);
        }

        public void EditBook(string bookISBN, Book bookReplacement)
        {
            if (bookReplacement.ISBN != bookISBN)
            {
                bookReplacement.ISBN = bookISBN;
            }
            _libraryInstance.EditBook(bookISBN, bookReplacement);
        }

        public void RemoveBooknBook(Book book)
        {
            _libraryInstance.RemoveBook(book);
        }
    }
}
