using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Textbook : Book
    {
        public int MaxPrintedPage;

        public Textbook(
            string iSBN,
            string author,
            string title,
            string publicationYear,
            int maxPrintedPage
        )
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = true;
            CanPrint = true;
            MaxPrintedPage = maxPrintedPage;
        }

        public override void PrintPages(int startPage, int endPage)
        {
            if (endPage - startPage > MaxPrintedPage)
            {
                Console.WriteLine(
                    $"The maximum amount of page that can be printed is {MaxPrintedPage}."
                );
            }
            else
            {
                Console.WriteLine($"Printing page {startPage} to page {endPage}...");
            }
        }
    }
}
