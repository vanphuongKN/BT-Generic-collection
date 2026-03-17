

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            int n;
            Console.Write("Nhap n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhap so hop le: ");
            }

            List<int> danhsach = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int so;
                Console.Write($"Nhap so thu {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out so))
                {
                    Console.Write("Nhap so hop le: ");
                }
                danhsach.Add(so);
            }

            Dictionary<int, int> dem = new Dictionary<int, int>();

            foreach (int so in danhsach)
            {
                if (dem.ContainsKey(so))
                    dem[so]++;
                else
                    dem[so] = 1;
            }

            int soMax = danhsach[0];
            int maxLan = dem[soMax];

            foreach (var item in dem)
            {
                if (item.Value > maxLan)
                {
                    maxLan = item.Value;
                    soMax = item.Key;
                }
            }

            Console.WriteLine($"So xuat hien nhieu nhat: {soMax} ({maxLan} lan)");
        }
    }
}