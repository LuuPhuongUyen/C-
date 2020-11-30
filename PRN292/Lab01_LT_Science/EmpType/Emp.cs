using CSharp_4.Enum;
using System;

namespace CSharp_4
{
    class Emp
    {
        public string Name { get; set; }

        public string DOB { get; set; }

        public Degree Degree { get; set; }

        public virtual void Input()
        {
            Console.Write("\t\t\tEnter Name: ");
            Name = Console.ReadLine();
            Console.Write("\t\t\tDate of birth: ");
            DOB = Console.ReadLine();
            Console.Write("\t\t\tDegree 0/1/2: ");
            Degree = (Degree)int.Parse(Console.ReadLine());
        }

        public virtual void toString()
        {
            Console.WriteLine($"Full name: {Name} \nDate of Birth: {DOB} \nDegree: {Degree}");
        }





    }
}
