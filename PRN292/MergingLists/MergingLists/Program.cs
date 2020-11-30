using System;
using System.Collections.Generic;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num1 = Console.ReadLine().Split();
            List<int> list1 = new List<int>();
            for (int i = 0; i < num1.Length; i++)
            {
                list1.Add(int.Parse(num1[i]));
            }
            string[] num2 = Console.ReadLine().Split();
            List<int> list2 = new List<int>();
            for (int i = 0; i < num2.Length; i++)
            {
                list2.Add(int.Parse(num2[i]));
            }
            List<int> result = new List<int>();
            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                    if (i < list2.Count)
                    {
                        result.Add(list2[i]);
                    }
                }
            }
            if (list2.Count > list1.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    result.Add(list2[i]);
                    if (i < list1.Count)
                    {
                        result.Add(list1[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
