using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace Person
{
    class Person
    {
        string name;
        int age;
        /*public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }*/
        //Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age { get => age; set => age = value; }

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name} is {age} years old");
        }
        public override string ToString()
        {
            return $"Name: {Name} is {age} years old";
        }
    }
    class Student : Person
    {
        float grade;
        public Student(string name, int age, float grade) : base(name, age)
        {
            this.grade = grade;
        }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        /*p1.setName("A");
        Console.WriteLine(p1.getName());*/
        p1.Name = "An";
        p1.Age = 41;
        //Console.WriteLine(p1.Name);
        Console.WriteLine(p1);//toString
        p1.Display();
        Console.ReadLine();
    }
}
}
