using System;
using System.Collections.Generic;

namespace CSharp_4.Main
{
    class Program
    {
        List<Emp> EmpList = new List<Emp>();

        public void InputList()
        {
            int Num;
            int EmpType;
            Emp Emps = null;
            Console.WriteLine("Enter number of employees: ");
            Num = int.Parse(Console.ReadLine());
            for (int i = 0; i <  Num; i++)
            {
                Console.WriteLine($"\tEmpployee no {i+1}: ");
                Console.WriteLine("\tType of Employee: ");
                Console.WriteLine("\t\t\t1. Manager");
                Console.WriteLine("\t\t\t2. Scientist");
                Console.WriteLine("\t\t\t3. Lab emplyees");
                Console.Write("\t\tChoose: ");

                EmpType = int.Parse(Console.ReadLine());

                switch(EmpType)
                {
                    case 1:
                        Console.WriteLine("\t\t\tEnter Manager's information: ");
                        Emps = new Manager();
                        break;
                    case 2:
                        Console.WriteLine("\t\t\tEnter Scientist's information: ");
                        Emps = new Scientist();
                        break;
                    case 3:
                        Console.WriteLine("\t\t\tEnter LabEmployee's information: ");
                        Emps = new LabEmp();
                        break;
                    default:
                        break;
                }
                Emps.Input();
                EmpList.Add(Emps);
            }

        }

        public void Output()
        {
            foreach (Emp emps in EmpList)
            {
                emps.toString();
                Console.WriteLine("=================");
            }
        }


        
    }
}
