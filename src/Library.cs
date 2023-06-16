using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Library
    {
        public List<Book> Book;
        private List<Person> _person;
        private static readonly Library _instance = new Library();
        public static Library Instance
        {
            get { return _instance; }
        }

        public Library()
        {
            Book = new List<Book>();
            _person = new List<Person>();
        }

        public void AddBook(Book book)
        {
            Book.Add(book);
        }

        public void EditBook(string bookISBN, Book bookReplacement)
        {
            var bookInLibrary = Book.FindIndex(c => c.ISBN == bookISBN);
            Book[bookInLibrary] = bookReplacement;
        }

        public void BorrowBook(Book book, Customer borrower)
        {
            var borrowedBook = Book.Find(c => book.ISBN == c.ISBN);
            if (borrowedBook != null)
            {
                borrowedBook.IsBorrowed = true;
                borrower.BorrowBook(borrowedBook); //Adds to customer's borrowed book list.
            }
        }

        public void ReturnBook(Book book, Customer borrower)
        {
            var borrowedBook = Book.Find(c => book.ISBN == c.ISBN);
            if (borrowedBook != null)
            {
                borrowedBook.IsBorrowed = false;
                borrower.ReturnBook(borrowedBook); //Adds to customer's borrowed book list.
            }
        }

        public void RemoveBook(Book book) { }

        public void AddPerson(Person person) { }

        public void RemovePerson(Person person) { }

        public void EditPerson(Person person) { }
    }
}
