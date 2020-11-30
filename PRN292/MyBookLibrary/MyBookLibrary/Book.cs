using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string publisher { get; set; }
        public double price { get; set; }

        public Book()
        {
        }

        public Book(int id, string name, string publisher, double price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }

        public override string ToString()
        {
            return "ID: " + id + ", Name: " + name + ", Publisher: " + publisher + ", Price: " + price;
        }
        public int menu()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("|     1. Add new book.         |");
            Console.WriteLine("|     2. Update a  book.       |");
            Console.WriteLine("|     3. Delete a book.        |");
            Console.WriteLine("|     4. Display all books.    |");
            Console.WriteLine("|     5. EXIT                  |");
            Console.WriteLine("--------------------------------");
            Console.Write("Enter your choice: ");
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine());
                    if (result < 1 || result > 5)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return result;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Must be input integer from 1 to 5.");
                    Console.WriteLine("Enter again: ");
                }
            }
        }
        List<Book> books = new List<Book>();
        public double checkInputPrice()
        {
            while (true)
            {
                try
                {
                    double price = double.Parse(Console.ReadLine());
                    if (price <= 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return price;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Price must be greater than 0");
                    Console.WriteLine("Enter price again: ");
                }
            }
        }
        public bool checkIdExist(List<Book> ls, int id)
        {
            foreach (var item in ls)
            {
                if (id.Equals(item.id))
                {
                    return false;
                }
            }
            return true;
        }
        public void AddNewBook()
        {
            Book book = new Book();
            Console.Write("ID: ");
            book.id = int.Parse(Console.ReadLine());
            while (!checkIdExist(books, book.id))
            {
                Console.WriteLine("ID existed. Please re-input.");
                Console.Write("ID: ");
                book.id = int.Parse(Console.ReadLine());
            }
            Console.Write("Name: ");
            book.name = Console.ReadLine();
            Console.Write("Publisher: ");
            book.publisher = Console.ReadLine();
            Console.Write("Price: ");
            book.price = checkInputPrice();
            books.Add(book);
            Console.WriteLine("Add book successfully!");
        }
        public Book FindIndex(int id)
        {
            Book book = books.Find((Book b) => { return (b.id == id); });
            return book;
        }
        public int FindBookIndex(int id)
        {
            int index = books.FindIndex(x => x.id == id);
            return index;
        }
        public void UpdateBook()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            while (checkIdExist(books, id))
            {
                Console.WriteLine("ID not found. Please re-input.");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
            }
            int index = FindBookIndex(id);
            Console.Write("Book's new name: ");
            books[index].name = Console.ReadLine();
            Console.Write("Book's new publisher: ");
            books[index].publisher = Console.ReadLine();
            Console.Write("Book's new price: ");
            books[index].price = checkInputPrice();
            Console.WriteLine("Updated successfully!");
        }
        public void DeleteBook()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            while (checkIdExist(books, id))
            {
                Console.WriteLine("ID not found. Please re-input.");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
            }
            int index = FindBookIndex(id);
            Console.Write("You want to delete this book? Yes?");
            string option = Console.ReadLine();
            if (string.Equals(option, "yes", StringComparison.OrdinalIgnoreCase))
            {
                books.RemoveAt(index);
                Console.WriteLine("Deleted successfully!");
            }
            else
            {
                Console.WriteLine("Failed to delete!");
                return;
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("");
            if (books.Any() != true)
            {
                Console.WriteLine("No book in the list!");
            }
            else
            {
                foreach (var item in books)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

