using System;
using System.Collections;
using System.Collections.Generic;

namespace SumAdjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(" ");
            List<int> list = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                list.Add(int.Parse(num[i]));
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] *= 2;
                    list.RemoveAt(i + 1);
                    i = -1;
                }
            }
            foreach (var x in list)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
