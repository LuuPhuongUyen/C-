using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSort
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Mark { get; set; }

        public Student(int ID, string Name, float Mark)
        {
            this.ID = ID;
            this.Name = Name;
            this.Mark = Mark;
        }
        public override string ToString()
        {
            return ID + "\t" + Name + "\t" + Mark;
        }
    }
}
