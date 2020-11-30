using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01Animal
{
    class Duck : Animal
    {
        private String name;

        public Duck(string name) : base("Duck")
        {
            this.name = name;
        }
        public override string information()
        {
            return "Type: " + type + ", name: " + name;
        }
        public override string sound()
        {
            return "quac quac";
        }
        public string swim(string state)
        {
            return state;
        }
    }
}
