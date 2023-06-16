using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Comic : Book
    {
        public string Artist;

        public Comic(
            string iSBN,
            string author,
            string title,
            string publicationYear,
            string artist
        )
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = true;
            CanPrint = false;
            Artist = artist;
        }

        public override void PrintPages(int startPage, int endPage)
        {
            Console.WriteLine("This book can not be printed.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine(
                $"ISBN: {ISBN} Author:{Author} Title: {Title} Publication year: {PublicationYear} Artist: {Artist} Borrowable: {CanBorrow} Printable: {CanPrint}"
            );
        }
    }
}
