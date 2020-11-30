using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "A";
            int age=41;
            Console.WriteLine("Name "+name+" Age "+age);
            Console.WriteLine("Name ={0}, Age ={1}", name, age);
            Console.WriteLine($"Name ={name},Age={age}");
        }
    }
}
