using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging2
{
    class SortAuthor : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }
}
