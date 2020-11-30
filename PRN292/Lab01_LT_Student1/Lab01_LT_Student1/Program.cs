using System;

namespace Lab01_LT_Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap Diem TB: ");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
    }
}
