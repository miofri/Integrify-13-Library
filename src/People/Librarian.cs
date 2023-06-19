using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public interface ILibrarian
    {
        void AddBook(Book book);
        void EditBook(string bookISBN, Book bookReplacement);
        void RemoveBook(Book book);
    }

    public class Librarian : Person, ILibrarian
    {
        private Library _libraryInstance = Library.Instance;

        public Librarian(string name, string address)
            : base(name, address) { }

        public void AddBook(Book book)
        {
            _libraryInstance.AddBook(book);
        }

        public void EditBook(string bookISBN, Book bookReplacement)
        {
            _libraryInstance.EditBook(bookISBN, bookReplacement);
        }

        public void RemoveBook(Book book)
        {
            _libraryInstance.RemoveBook(book);
        }
    }
}
