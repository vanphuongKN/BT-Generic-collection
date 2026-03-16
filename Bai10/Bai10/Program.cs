namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap n: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhap so nguyen hop le: ");
            }

            List<int> danhsach = new List<int>();

            Console.WriteLine("Nhap cac so:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                int so = int.Parse(Console.ReadLine());
                danhsach.Add(so);
            }
            int min = danhsach[0];

            for (int i = 1; i < danhsach.Count; i++)
            {
                if (danhsach[i] < min)
                {
                    min = danhsach[i];
                }
            }
            Console.WriteLine("Gia tri nho nhat trong danh sach: " + min);
        }
    }
}
