using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_BookManaging2
{
    class Book : IBook, IComparable<Book>
    {
        private ArrayList chapter = new ArrayList();
        string IBook.this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public void Show()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0} : {1}", i + 1, chapter[i]);
            Console.WriteLine("--------------------------------");
        }
        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Chapter (Finshed with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            }
            while (str.Length > 0);
        }
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}
