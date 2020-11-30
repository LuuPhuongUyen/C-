using System;
using System.Collections.Generic;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            List<int> list = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                list.Add(int.Parse(num[i]));
            }
            int length = list.Count / 2;
            for (int i = 0; i < length; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.WriteLine(string.Join(" ", list));
            Console.ReadLine();
        }
    }
}
