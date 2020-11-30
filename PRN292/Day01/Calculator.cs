using System;

namespace Calculator
{

    class Calculator
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter operator: ");
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("b must #0");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", a, b, a / (float)b);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
