using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging
{
    class BookList
    {
        private List<Book> list = new List<Book>();
        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }
        public void InputList()
        {
            int n;
            Console.Write("Amount of Books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }
}
