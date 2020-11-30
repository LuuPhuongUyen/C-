using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_LT_Student2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student()
        {
        }

        public Student(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}\n", this.DiemTB);
        }

        Student[] DSSV;
        public void Nhap1SV(int i)
        {
            int id;
            String ten, khoa;
            float diemTB;
            Console.Write("Nhap MaSV: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV: ");
            ten = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            diemTB = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Student stu = new Student(id, ten, khoa, diemTB);
            DSSV[i] = stu;
        }

        public void NhapDS()
        {
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Nhap1SV(i);
            }

        }

        public void XuatDS()
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student st in DSSV)
                st.Show();
        }
    }
}
