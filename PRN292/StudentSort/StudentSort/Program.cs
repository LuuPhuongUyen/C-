using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ArrayList arrStudent = new ArrayList();
            arrStudent.Add(new Student(1, "A", 9.3f));
            arrStudent.Add(new Student(2, "B", 8.8f));
            arrStudent.Add(new Student(3, "N", 9.0f));
            Console.WriteLine(arrStudent[2]);
            Console.WriteLine("Student list: ");
            foreach (Student st in arrStudent)
            {
                Console.WriteLine(st);
            }
            arrStudent.Sort(new SortName());
            Console.WriteLine("After sorting name: ");
            foreach (Student st in arrStudent)
            {
                Console.WriteLine(st.ToString());
            }
            arrStudent.Sort(new SortID());
            Console.WriteLine("After sorting id: ");
            foreach (Student st in arrStudent)
            {
                Console.WriteLine(st.ToString());
            }
            arrStudent.Sort(new SortMark());
            Console.WriteLine("After sorting mark: ");
            foreach (Student st in arrStudent)
            {
                Console.WriteLine(st.ToString());
            }
            Console.ReadLine();
        }
    }
}
