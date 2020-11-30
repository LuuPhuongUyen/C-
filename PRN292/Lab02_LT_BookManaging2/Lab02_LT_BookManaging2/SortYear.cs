using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging2
{
    class SortYear : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
}
