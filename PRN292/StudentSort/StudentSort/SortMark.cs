using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentSort
{
    class SortMark : IComparer
    {
        public int Compare(object x, object y)
        {
            Student st1 = x as Student;
            Student st2 = y as Student;
            return st1.Mark.CompareTo(st2.Mark);
        }
    }
}
