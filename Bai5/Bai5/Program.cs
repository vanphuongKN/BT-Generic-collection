

namespace Bai5
{
    internal class Program
    {
        static void InDanhSach(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("(Danh sách trống)");
                return;
            }

            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<string> dsSinhVien = new List<string> { "Phuong", "Nguyen", "Thien", "Vien" };

            Console.Write("Danh sách sinh viên: ");
            InDanhSach(dsSinhVien);

            Console.Write("Nhập tên cần xóa: ");
            string tenCanXoa = Console.ReadLine();

            bool timThay = false;

            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].Equals(tenCanXoa, StringComparison.OrdinalIgnoreCase))
                {
                    dsSinhVien.RemoveAt(i);
                    timThay = true;
                    break;
                }
            }

            if (timThay)
                Console.WriteLine("Đã xóa thành công: " + tenCanXoa);
            else
                Console.WriteLine("Không tìm thấy sinh viên: " + tenCanXoa);

            Console.Write("Danh sách sau khi xóa: ");
            InDanhSach(dsSinhVien);

            Console.ReadLine();
        }
    }
}