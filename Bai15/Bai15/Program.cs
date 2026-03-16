
namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> tudien = new Dictionary<string, string>();

            tudien.Add("hello", "xin chao");
            tudien.Add("book", "quyen sach");
            tudien.Add("computer", "may tinh");
            tudien.Add("school", "truong hoc");

            Console.Write("Nhap tu tieng Anh can tra: ");
            string tu = Console.ReadLine().ToLower();

            if (tudien.ContainsKey(tu))
            {
                Console.WriteLine("Nghia tieng Viet: " + tudien[tu]);
            }
            else
            {
                Console.WriteLine("Khong tim thay tu nay trong tu dien");
            }
        }
    }
}