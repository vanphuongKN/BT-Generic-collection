namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<int> so = new List<int>();
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                so.Add(int.Parse(Console.ReadLine()));
            }

            int n_phantu = so.Count;

            for (int i = 0; i < n_phantu - 1; i++)
            {
                for (int j = 0; j < n_phantu - i - 1; j++)
                {
                    if (so[j] > so[j + 1])
                    {
                        int tg = so[j];   
                        so[j] = so[j + 1];  
                        so[j + 1] = tg; 
                    }
                }
            }
            Console.WriteLine("In danh sach tang dan");
            foreach (int item in so)
            {
                Console.Write(item + " ");
            }
        }
    }
}
