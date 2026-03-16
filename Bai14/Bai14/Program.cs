namespace Bai14
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

            List<Student> danhSachSinhVien = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();

                Console.Write($"Nhap ID sinh vien {i + 1}: ");
                sv.Id = int.Parse(Console.ReadLine());

                Console.Write($"Nhap ten sinh vien {i + 1}: ");
                sv.Name = Console.ReadLine();

                danhSachSinhVien.Add(sv);
            }

            Console.Write("Nhap ID sinh vien can xoa: ");
            int idCanXoa = int.Parse(Console.ReadLine());
            Student sinhVienCanXoa = null;
            for (int i = 0; i < danhSachSinhVien.Count; i++)
            {
                if (danhSachSinhVien[i].Id == idCanXoa)
                {
                    danhSachSinhVien.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Danh sach sinh vien sau khi xoa:");
            foreach (Student sv in danhSachSinhVien)
            {
                Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");
            }
        }
    }
}
