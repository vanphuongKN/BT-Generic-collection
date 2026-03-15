namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");
            List<int> so = new List<int>();
            Console.WriteLine("Nhap 5 so bat ky");
            for(int i =0; i < 5; i++)
            {
                Console.WriteLine($"Nhap so thu {i}: ");
                string Nhap = Console.ReadLine();
                int n = int.Parse(Nhap);
                so.Add(n);
            }
            for (int i = 0; i <5; i++)
            {
                Console.Write(so[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
