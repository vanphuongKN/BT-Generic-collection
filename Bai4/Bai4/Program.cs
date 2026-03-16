

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap so luong phan tu n: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Vui long nhap so nguyen hop le: ");
            }

            List<int> danhsach = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thư {i + 1}: ");
                int so;

                while (!int.TryParse(Console.ReadLine(), out so))
                {
                    Console.Write("Nhap lại so nguyen hop le : ");
                }

                danhsach.Add(so);
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