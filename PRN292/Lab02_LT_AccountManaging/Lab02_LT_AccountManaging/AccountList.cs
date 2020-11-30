using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Lab02_LT_AccountManaging
{
    class AccountList
    {
        List<Account> acccountList = new List<Account>();
        public void NewAccount()
        {
            Account a = new Account();
            a.FillInfo();
            acccountList.Add(a);
        }

        public void SaveFile()
        {
            Console.Write("File name to save: ");
            string filename = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account acc in acccountList)
                {
                    writer.WriteLine("{0},{1},{2},{3}", acc.Id, acc.FirstName, acc.LastName, acc.Balance);

                }
                writer.Close();
                output.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();
            acccountList.Clear();
            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(",");
                    Account acc = new Account(int.Parse(list[0]), list[1], list[2], double.Parse(list[3]));
                    acccountList.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void saveFileBySerializable()
        {
            Console.Write("Input file name: ");
            string filename = Console.ReadLine();

            using (var stream = File.OpenWrite(filename))
            {
                var formatter = new BinaryFormatter();
                foreach (Account a in acccountList)
                {
                    formatter.Serialize(stream, a);
                }
                stream.Close();
            }
        }
        public void Report()
        {
            Console.WriteLine("Origin: ");
            foreach (Account a in acccountList)
                a.Query();

            Console.WriteLine("Sort By Id: ");
            acccountList.Sort(new SortByID());
            foreach (Account a in acccountList)
                a.Query();

            Console.WriteLine("Sort By First Name: ");
            acccountList.Sort(new SortByFirstName());
            foreach (Account a in acccountList)
                a.Query();

            Console.WriteLine("Sort By Balance: ");
            acccountList.Sort(new SortByBalance());
            foreach (Account a in acccountList)
                a.Query();
        }
    }
}

