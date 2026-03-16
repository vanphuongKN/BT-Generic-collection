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

            List<Student> danhSachSinhVien = new List<Student>();
            danhSachSinhVien.Add(new Student { Id = 1, Name = "Vo Van Phuong" });
            danhSachSinhVien.Add(new Student { Id = 2, Name = "Vo Thi Quynh Duyen" });
            danhSachSinhVien.Add(new Student { Id = 3, Name = "Vo Thi Ngoc Han" });

            Console.Write("Nhap ID sinh vien can xoa: ");
            int idCanXoa = int.Parse(Console.ReadLine());
            Student sinhVienCanXoa = null;
            foreach (Student sv in danhSachSinhVien)
            {
                if (sv.Id == idCanXoa)
                {
                    sinhVienCanXoa = sv; 
                    break;
                }
            }
            if (sinhVienCanXoa != null)
            {
                danhSachSinhVien.Remove(sinhVienCanXoa); 
                Console.WriteLine("Da xoa thanh cong sinh vien co ID: " + idCanXoa);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien nao co ID la: " + idCanXoa);
            }
            foreach (Student sv in danhSachSinhVien)
            {
                Console.WriteLine("Ma SV: " + sv.Id + "  Ho ten: " + sv.Name);
            }
        }
    }
}
