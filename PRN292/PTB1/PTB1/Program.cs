using System;

namespace PTB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if(b == 0)
                { 
                    Console.WriteLine("Infinite"); 
                }
                else { Console.WriteLine("a must #0"); }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"One root x = {x}");
            }
        }
    }
}
