using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_LT_AccountManaging
{
    class Account
    {
        private int id;
        private string firstName;
        private string lastName;
        private double balance;

        public Account() { }
        public Account(int id, string firstName, string lastName, double balance)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }
        public void FillInfo()
        {
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Balance: ");
            balance = double.Parse(Console.ReadLine());
        }

        public void Query()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("--------------------------------");
        }
    }
}
