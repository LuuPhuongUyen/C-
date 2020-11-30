using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_LT_Student3
{
    class Student : People
    {
        private int SID;
        private string Khoa;
        private float DiemTB;
        public Student()
        {
        }
        public Student(String name, String gender, int id, string khoa, float dtb) : base(name, gender)
        {
            this.SID = id;
            this.Khoa = khoa;
            this.DiemTB = dtb;
        }
        public int SIDProperty
        {
            get { return SID; }
            set { SID = value; }
        }

        public String KhoaProperty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float DiemTBProperty
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", NameProperty);
            Console.WriteLine("Gioi tinh: {0}", GenderProperty);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
            Console.WriteLine("");
        }
        List<Student> DSSV = new List<Student>();
        public void Nhap1SV()
        {
            Console.Write("Nhap MaSV: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            string khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            float diem = float.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            string gender = Console.ReadLine();
            Console.WriteLine("");
            DSSV.Add(new Student(ten, gender, id, khoa, diem));
        }
        public void NhapDS()
        {
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Nhap1SV();
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
