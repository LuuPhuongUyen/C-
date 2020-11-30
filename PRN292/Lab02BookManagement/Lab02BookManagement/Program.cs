using System;
using MyBookLibrary;
namespace Lab02BookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            while (true)
            {
                int choice = b.menu();
                switch (choice)
                {
                    case 1:
                        b.AddNewBook();
                        break;
                    case 2:
                        b.UpdateBook();
                        break;
                    case 3:
                        b.DeleteBook();
                        break;
                    case 4:
                        b.DisplayBooks();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
