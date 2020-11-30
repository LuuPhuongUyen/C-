using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging
{
    interface IBook
    {
        string this[int index] { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        string ISBN { get; set; }
        int Year { get; set; }

        public void Show();
    }
}
