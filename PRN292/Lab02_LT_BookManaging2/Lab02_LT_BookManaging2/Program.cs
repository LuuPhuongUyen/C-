using System;

namespace Lab02_LT_BookManaging2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList b = new BookList();
            b.InputList();
            b.ShowList();
            Console.ReadLine();
        }
    }
}
