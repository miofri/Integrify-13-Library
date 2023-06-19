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
            if (bookReplacement.ISBN != bookISBN)
            {
                bookReplacement.ISBN = bookISBN;
            }
            var bookInLibrary = Book.FindIndex(c => c.ISBN == bookISBN);
            Book[bookInLibrary] = bookReplacement;
        }

        public virtual void BorrowBook(Book book, Customer borrower)
        {
            if (borrower.BorrowedBook.Find(b => b.ISBN == book.ISBN) != null)
            {
                Console.WriteLine("Book has already been borrowed by this customer!");
                return;
            }
            var borrowedBook = Book.Find(c => book.ISBN == c.ISBN);
            if (borrowedBook != null && borrowedBook.IsBorrowed != true)
            {
                borrowedBook.IsBorrowed = true;
                borrower.BorrowBook(borrowedBook); //Adds to customer's borrowed book list.
                Console.WriteLine($"Book is now borrowed by customer {borrower._name}");
            }
            else
            {
                Console.WriteLine("This book is currently unavailable");
            }
        }

        public virtual void ReturnBook(Book book, Customer borrower)
        {
            if (borrower.BorrowedBook.Find(b => b.ISBN == book.ISBN) != null)
            {
                Console.WriteLine("This customer did not borrow this book!");
                return;
            }
            var borrowedBook = Book.Find(c => book.ISBN == c.ISBN);
            if (borrowedBook != null)
            {
                borrowedBook.IsBorrowed = false;
                borrower.ReturnBook(borrowedBook); //Adds to customer's borrowed book list.
            }
        }

        public virtual void RemoveBook(Book book)
        {
            Book.Remove(book);
        }

        public void AddPerson(Person person)
        {
            _person.Add(person);
        }

        public void RemovePerson(Person person)
        {
            _person.Remove(person);
        }

        public void EditPerson(Person newPerson, Person person)
        {
            if (newPerson.GetId != person.GetId)
            {
                newPerson.GetId = person.GetId;
            }
            var findPerson = _person.FindIndex(p => p.GetId == person.GetId);
            if (findPerson != -1)
            {
                _person[findPerson] = newPerson;
            }
        }
    }
}
