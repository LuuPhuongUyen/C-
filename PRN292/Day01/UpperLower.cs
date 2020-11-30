using System;

namespace UpperLower
{
    class UpperLower
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            String str = Console.ReadLine();
            int upper = 0, lower = 0, number = 0, bs = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= '0' && ch <= '9')
                    number++;
                else if(ch==' ')
                    bs++;
            }
            Console.WriteLine("Upper case letters: " + upper);
            Console.WriteLine("Lower case letters: " + lower);
            Console.WriteLine("Number: " + number);
            Console.Write("Blank space: " + bs);
        }
    }
}
