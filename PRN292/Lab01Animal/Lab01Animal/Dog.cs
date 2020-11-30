using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01Animal
{
    class Dog : Animal
    {
        private String name, breed;
        public Dog(string name, string breed) : base("Dog")
        {
            this.name = name;
            this.breed = breed;
        }
        public override string information()
        {
            return "Type: " + type + ", name: " + name + ", breed: " + breed;
        }
        public override string sound()
        {
            return "gâu gâu";
        }
    }
}
