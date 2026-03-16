
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

            Dictionary<char, int> demKyTu = new Dictionary<char, int>();

            foreach (char c in chuoi)
            {
                if (demKyTu.ContainsKey(c))
                {
                    demKyTu[c]++;
                }
                else
                {
                    demKyTu.Add(c, 1);
                }
            }

            Console.WriteLine("So lan xuat hien cua tung ky tu:");

            foreach (KeyValuePair<char, int> item in demKyTu)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}