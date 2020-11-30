using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
        }
    }
}
