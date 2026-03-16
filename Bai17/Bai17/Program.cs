namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> danhsach = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                int so = int.Parse(Console.ReadLine());
                danhsach.Add(so);
            }

            Dictionary<int, int> dem = new Dictionary<int, int>();

            foreach (int so in danhsach)
            {
                if (dem.ContainsKey(so))
                    dem[so]++;
                else
                    dem.Add(so, 1);
            }

            int soXuatHienNhieuNhat = 0;
            int max = 0;

            foreach (KeyValuePair<int, int> item in dem)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    soXuatHienNhieuNhat = item.Key;
                }
            }

            Console.WriteLine($"So xuat hien nhieu nhat: {soXuatHienNhieuNhat} ({max} lan)");
        }

    
    }
}
