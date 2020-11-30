using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_LT_Student3
{
    class People
    {
        private string name;
        private string gender;

        public People()
        {
        }
        public People(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
        }
        public string GenderProperty
        {
            get { return gender; }
            set { gender = value; }
        }
        public string NameProperty
        {
            get { return name; }
            set { name = value; }
        }
    }
}
