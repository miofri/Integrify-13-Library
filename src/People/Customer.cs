using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Customer : Person
    {
        private Library _libraryInstance;

        public Customer(string name, string address)
            : base(name, address)
        {
            _libraryInstance = Library.Instance;
        }

        public void BorrowBook(Book book)
        {
            _libraryInstance.BorrowBook(book);
        }

        public void ReturnBook(Book book)
        {
            _libraryInstance.ReturnBook(book);
        }
    }
}
