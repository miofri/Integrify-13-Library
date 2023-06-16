using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class ResearchPaper : Book
    {
        public ResearchPaper(string iSBN, string author, string title, string publicationYear)
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = false;
            CanPrint = true;
        }

        public override void Borrow()
        {
            Console.WriteLine("This book is not borrow-able!");
        }
    }
}
