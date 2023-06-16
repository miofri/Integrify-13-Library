using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Book
    {
        public string ISBN;
        public string Author;
        public string Title;
        public string PublicationYear;
        public bool CanBorrow;
        public bool CanPrint;
        public bool IsBorrowed;

        public Book(string iSBN, string author, string title, string publicationYear)
        {
            ISBN = iSBN;
            Author = author;
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void Borrow()
        {
            Console.WriteLine($"{Title} by {Author} is now borrowed");
        }

        public virtual void Return()
        {
            Console.WriteLine($"{Title} by {Author}has been returned");
        }

        public virtual void PrintPages(int startPage, int endPage)
        {
            Console.WriteLine("This book is not printable");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(
                $"ISBN: {ISBN} Author:{Author} Title: {Title} Publication year: {PublicationYear} Borrowable: {CanBorrow} Printable: {CanPrint}"
            );
        }
    }
}
