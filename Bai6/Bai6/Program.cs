

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<string> traiCay = new List<string> { "Dao", "Chuoi", "Cam", "Xoai", "Man" };

            Console.Write("Nhập tên loại trái cây bạn muốn tìm: ");
            string timKiem = Console.ReadLine();

            bool timThay = false;

            foreach (string item in traiCay)
            {
                if (item.Equals(timKiem, StringComparison.OrdinalIgnoreCase))
                {
                    timThay = true;
                    break;
                }
            }

            if (timThay)
                Console.WriteLine($"Trái '{timKiem}' có trong danh sách.");
            else
                Console.WriteLine($"Trái '{timKiem}' không có trong danh sách.");
        }
    }
}