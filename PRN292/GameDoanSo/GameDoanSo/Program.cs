using System;

namespace GameDoanSo
{
    class GameDoanSo
    {
        static int check(int n, int random)
        {
            if (n == random) return 0;
            if (n < random) return -1;
            else return 1;
        }
        static void guess(int random)
        {
            bool win = false;
            int x = 0;
            Console.Write("Guess number: ");
            for (int i = 0; i < 7; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (check(n, random) == -1) 
                    Console.WriteLine("Your number is smaller");
                else if (check(n, random) == 1) 
                    Console.WriteLine("Your number is bigger");
                else { 
                    win = true; 
                    break; 
                };
                x++;
            }
            if (win) Console.WriteLine("You won!");
            else if (x == 7) Console.WriteLine("END");
            Console.WriteLine($"The Answer: {random}");
        }
        static int random()
        {
            Random pick = new Random();
            int n = pick.Next(1, 100);
            return n;
        }
        static void Main(string[] args)
        {
            int n = random();
            guess(n);
        }
    }
}
