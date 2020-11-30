using CSharp_4.Enum;
using System;

namespace CSharp_4
{
    class Manager : Emp 
    {
        public Position Position { get; set; }
        public int WorkingDay{ get; set; }
        public double SalaryLevel { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("\t\t\tPosition: 0.Pos0 1.Pos1 2.Pos2 : ");
            Position = (Position) int.Parse(Console.ReadLine());

            Console.Write("\t\t\tWorking day this month: ");
            WorkingDay = int.Parse(Console.ReadLine());

            Console.Write("\t\t\tLevel of salary: ");
            SalaryLevel= double.Parse(Console.ReadLine());
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine($"Position: {Position} \nWorking day: {WorkingDay} \nSalary level: {SalaryLevel}\nSalary total: {WorkingDay*SalaryLevel}" );
        }
    }
}
