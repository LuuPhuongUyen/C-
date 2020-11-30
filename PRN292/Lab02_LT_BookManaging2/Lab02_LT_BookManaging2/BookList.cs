using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging2
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
            Console.WriteLine("Sort Title");
            list.Sort(); 
            foreach (Book b in list)
                b.Show();

            Console.WriteLine("Sort Author");
            list.Sort(new SortAuthor());
            foreach (Book b in list)
                b.Show();

            Console.WriteLine("Sort Publisher");
            list.Sort(new SortPublisher());
            foreach (Book b in list)
                b.Show();

            Console.WriteLine("Sort ISBN");
            list.Sort(new SortISBN());
            foreach (Book b in list)
                b.Show();

            Console.WriteLine("Sort Year");
            list.Sort(new SortYear());
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
