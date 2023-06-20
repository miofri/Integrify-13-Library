using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.src
{
    public class Novel : Book
    {
        public string Genre;

        public Novel(string iSBN, string author, string title, string publicationYear, string genre)
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = true;
            CanPrint = false;
            Genre = genre;
        }

        public override void PrintPages(int startPage, int endPage)
        {
            Console.WriteLine("This book can not be printed.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine(
                $"ISBN: {ISBN} Author:{Author} Title: {Title} Publication year: {PublicationYear} Genre: {Genre} Borrowable: {CanBorrow} Printable: {CanPrint}"
            );
        }
    }
}
