using System;

namespace Prime
{
    class Program
    {
        static int isPrime(int n)
        {
            int i;
            if (n < 2)
            {
                Console.Write("Reenter n: ");
                n = int.Parse(Console.ReadLine());
            }
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
           int n = int.Parse(Console.ReadLine());
            if (isPrime(n) == 0)
            {
                Console.Write($"{n} is not a prime");
            }else if (isPrime(n) == 1)
                Console.Write($"{n} is a prime");
        }
    }
}
