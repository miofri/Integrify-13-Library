using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Customer : Person
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
            // _libraryInstance.BorrowBook(book);
        }

        public void ReturnBook(Book book)
        {
            BorrowedBook.Remove(book);
        }
    }
}
