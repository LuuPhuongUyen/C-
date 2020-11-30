using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01Animal
{
    class Cat : Animal
    {
        private String name;
        public Cat(string name) : base("Cat")
        {
            this.name = name;
        }
        public override string information()
        {
            return "Type: " + type + ", name: " + name;
        }
        public override string sound()
        {
            return "meo meo";
        }
        public string climb(string state)
        {
            return state;
        }
    }
}

