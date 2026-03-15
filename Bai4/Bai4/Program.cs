
namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> danhsach = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                danhsach.Add(int.Parse(Console.ReadLine()));
            }

            int dem = 0; 

            foreach (int so in danhsach)
            {
                if (so % 2 == 0) 
                {
                    dem++;
                }
            }
            Console.WriteLine($"Co {dem} so chan trong danh sach");
        }
    }
}
