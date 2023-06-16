using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Textbook : Book
    {
        public Textbook(string iSBN, string author, string title, string publicationYear)
            : base(iSBN, author, title, publicationYear)
        {
            CanBorrow = true;
            CanPrint = true;
        }
    }
}
