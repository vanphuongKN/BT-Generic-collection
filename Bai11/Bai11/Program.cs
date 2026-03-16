using System.Runtime.Intrinsics.Arm;

namespace Bai11
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

            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            List<Student> danhsachsinhvien = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();
                Console.Write($"Nhap ID sinh vien {i + 1}: ");
                sv.Id = int.Parse(Console.ReadLine());
                Console.Write($"Nhap ten sinh vien {i + 1}: ");
                sv.Name = Console.ReadLine();
                danhsachsinhvien.Add( sv );
            }
            Console.WriteLine("Danh sach sinh vien");
            foreach(Student sv in danhsachsinhvien)
            {
                Console.WriteLine("Ma sv:" + sv.Id+ " Ho ten: " + sv.Name);

            }
        }
    }
}
