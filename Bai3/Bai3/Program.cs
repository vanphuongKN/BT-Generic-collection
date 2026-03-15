
namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.WriteLine("Nhap n: "); 
            int n = int.Parse(Console.ReadLine());

            List<int > danhsach = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                danhsach.Add(int.Parse(Console.ReadLine()));

            }
            if (danhsach.Count > 0)
            {
                int max = danhsach[0];
                for (int i = 1; i < n; i++)
                {
                    if (danhsach[i] > max)
                        max = danhsach[i];
                }
                Console.WriteLine("so lon nhat trong day so la: "+max);
            }
            else
                Console.WriteLine("Danh sach trong");
            
        }
    }
}
