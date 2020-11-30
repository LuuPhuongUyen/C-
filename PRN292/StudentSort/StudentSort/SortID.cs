using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentSort
{
    class SortID : IComparer
    {
        public int Compare(object x, object y)
        {
            Student st1 = x as Student;
            Student st2 = y as Student;
            if (st1 == null || st2 == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                if (st1.ID.CompareTo(st2.ID) == 1) return -1;
                else if (st1.ID.CompareTo(st2.ID) == -1) return 1;
                else return 0;
            }
        }
    }
}
