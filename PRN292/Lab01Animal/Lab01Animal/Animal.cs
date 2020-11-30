using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01Animal
{
    abstract class Animal
    {
        protected String type;
        protected Animal(string type)
        {
            this.type = type;
        }
        public abstract String sound();
        public abstract String information();
    }
}
