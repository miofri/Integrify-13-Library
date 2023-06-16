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

        public Book(string iSBN, string author, string title, string publicationYear)
        {
            ISBN = iSBN;
            Author = author;
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void Borrow() { }

        public virtual void Return() { }

        public virtual void PrintPages(int startPage, int endPage)
        {
            Console.WriteLine($"This book can be printed from page {startPage} to page {endPage}");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(
                $"ISBN: {ISBN} Author:{Author} Title: {Title} Publication year: {PublicationYear} Borrowable: {CanBorrow} Printable: {CanPrint}"
            );
        }
    }
}
