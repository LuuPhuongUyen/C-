using System;

namespace Lab02_LT_AccountManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            AccountList a = new AccountList();
            do
            {
                Console.Write("Enter option: Add/Save/Load/Report/Exit: ");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "Add":
                        a.NewAccount();
                        break;
                    case "Save":
                        a.SaveFile();
                        break;
                    case "Load":
                        a.LoadFile();
                        break;
                    case "Report":
                        a.Report();
                        break;
                }
            }
            while (opt != "Exit");
        }
    }
}

