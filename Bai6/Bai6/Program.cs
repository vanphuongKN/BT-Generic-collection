namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<string> traiCay = new List<string> { "Dao", "Chuoi", "Cam", "Xoai", "Man" };
            Console.Write("Nhap ten loai trai cay ban muon tim: ");
            string timKiem = Console.ReadLine();
            if (traiCay.Contains(timKiem))
            {
                Console.WriteLine($"trai '{timKiem}' co trong danh sach.");
            }
            else
            {
                Console.WriteLine($"trai '{timKiem}' khong co trong danh sach.");
            }
        }
    }
}
