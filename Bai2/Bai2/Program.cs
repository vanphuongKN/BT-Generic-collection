namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV:2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.WriteLine("nhap do dai day so: ");
            int n = int .Parse(Console.ReadLine());

            List<int> danhsach = new List<int>();
            Console.WriteLine("Nhap cac so nguyen");
            for(int i= 0; i < n; i++)
            {
                Console.WriteLine($"Nhap so {i+1}:  " );
                danhsach.Add(int.Parse(Console.ReadLine()));
            }
            int tong = 0;
            for(int i= 0;i < n; i++)
            {
                tong = tong + danhsach[i];

            }
            Console.WriteLine("ket qua cua day so la: "+ tong);
        }
    }
}
