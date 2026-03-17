namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            if (string.IsNullOrEmpty(chuoi))
            {
                Console.WriteLine("Chuoi rong!");
                return;
            }

            Dictionary<char, int> demKyTu = new Dictionary<char, int>();

            foreach (char c in chuoi)
            {
                if (char.IsWhiteSpace(c)) continue;

                demKyTu[c] = demKyTu.ContainsKey(c) ? demKyTu[c] + 1 : 1;
            }

            Console.WriteLine("So lan xuat hien cua tung ky tu:");

            foreach (var item in demKyTu)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}