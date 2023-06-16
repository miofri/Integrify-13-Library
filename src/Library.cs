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

        public void AddBook(Book book) { }

        public void EditBook(Book book) { }

        public void BorrowBook(Book book) { }

        public void RemoveBook(Book book) { }

        public void ReturnBook(Book book) { }

        public void AddPerson(Person person) { }

        public void RemovePerson(Person person) { }

        public void EditPerson(Person person) { }
    }
}
