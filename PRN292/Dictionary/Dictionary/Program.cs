using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SortedDictionary<string, double> fruits = new SortedDictionary<string, double>();
            fruits["Oranges"] = 1;
            fruits.Add("Tomato", 1.5);
            fruits.Add("Banana", 1.5);
            Console.WriteLine(fruits.ContainsKey("Tomato"));
            foreach (var item in fruits)
            {
                Console.WriteLine();
            }
            Console.ReadLine();*/
            SortedDictionary<string, double> words = new SortedDictionary<string, double>();
            List<string> list = Console.ReadLine().Split().ToList();
            foreach(var item in list)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else words[item] = 1;//words.Add(item,1);
            }
            foreach ( var item in words)
            {
                Console.WriteLine(item) ;
            }
            Console.ReadLine();
        }
    }
}
