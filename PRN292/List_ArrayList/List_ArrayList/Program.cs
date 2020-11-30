using System;
using System.Collections;
using System.Collections.Generic;

namespace List_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listInt = new List<int>() { 1, 4, 6 };
            listInt.Add(3);
            listInt.Remove(4);
            Console.WriteLine("Before sorting: ");
            foreach (var item in listInt)
            {
                Console.WriteLine(item);
            }
            //After sorting
            listInt.Sort();
            Console.WriteLine(string.Join(", ",listInt));
            Console.ReadLine();*/
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add("Hello world");
            Console.ReadLine();
        }
    }
}
