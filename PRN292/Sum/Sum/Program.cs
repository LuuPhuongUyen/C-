using System;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            double n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
