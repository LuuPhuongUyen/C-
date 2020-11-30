using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.Write($"{year} is leap year");
            }
            else
                Console.Write($"{year} is not leap year");
        }
    }
}
