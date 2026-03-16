namespace Bai9
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
                Console.WriteLine("nhap so nguyen hop le: ");
            }
            List<int> danhsach = new List<int>();
            Console.WriteLine("Nhap cac so");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i+1}: ");
                int so = int.Parse(Console.ReadLine());
                danhsach.Add(so);
            }
            List<int> danhsachmoi = new List<int>();

            for(int i = 0; i < danhsach.Count; i++)
            {
                int sohientai = danhsach[i];
                if(danhsachmoi.Contains(sohientai) == false)
                    danhsachmoi.Add(sohientai);
            }
            Console.WriteLine("danh sach sau khi kiem tra trung lap: ");
            for (int i = 0; i < danhsachmoi.Count; i++)
            {
                Console.Write(danhsachmoi[i] + " ");
            }

        }
    }
}
