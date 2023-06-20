using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.src
{
    public interface ICustomer
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }

    public class Customer : Person, ICustomer
    {
        private Library _libraryInstance;
        public List<Book> BorrowedBook;

        public Customer(string name, string address)
            : base(name, address)
        {
            _libraryInstance = Library.Instance;
            BorrowedBook = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBook.Add(book);
            _libraryInstance.BorrowBook(book, this);
        }

        public void ReturnBook(Book book)
        {
            BorrowedBook.Remove(book);
            _libraryInstance.ReturnBook(book, this);
        }
    }
}
