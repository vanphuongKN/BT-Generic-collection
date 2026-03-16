namespace Bai13
{
    internal class Program
    {
        public class Student
        {
            public int Id;
            public string Name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<Student> danhSachSinhVien = new List<Student>();

            Student sv1 = new Student();
            sv1.Id = 1;
            sv1.Name = "Vo Van Phuong";
            danhSachSinhVien.Add(sv1);

            Student sv2 = new Student();
            sv2.Id = 2;
            sv2.Name = "Vo Thi Quynh Duyen";
            danhSachSinhVien.Add(sv2);

            int tongSoSinhVien = danhSachSinhVien.Count;
            Console.WriteLine("Tong so sinh vien trong danh sach la: " + tongSoSinhVien);
        }
    }
}
