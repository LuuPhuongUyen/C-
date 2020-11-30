using System;

namespace CSharp_4
{
    class LabEmp: Emp
    {
        public double Salary { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("\t\t\tSalary: ");
            Salary = double.Parse(Console.ReadLine());
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    
}
