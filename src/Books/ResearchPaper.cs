using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class ResearchPaper : Book
    {
        public int MaxPrintedPage;

        public ResearchPaper(
            string iSBN,
            string author,
            string title,
            string publicationYear,
            int maxPrintedPage
        )
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = false;
            CanPrint = true;
            MaxPrintedPage = maxPrintedPage;
        }

        public override void Borrow()
        {
            Console.WriteLine("This book is not borrow-able!");
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
