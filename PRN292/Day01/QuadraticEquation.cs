using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void linearEquation(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("b must be != 0");
            }
            else
            {
                Console.WriteLine("x = {0}", -b / (float)a);
            }
        }
        static void quadraticEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                linearEquation(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("No root");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("x1 = x2 = {0}", -b / (float)(2 * a));
                }
                else if (delta > 0)
                {
                    Console.WriteLine("x1 = {0}, x2 = {1}", (-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            quadraticEquation(a, b, c);
        }
    }
}
