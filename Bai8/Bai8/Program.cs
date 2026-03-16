namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");


            List<int> danhsach = new List<int>() { 1,24, 51,2,64 };
            danhsach.Reverse();
            foreach (int i in danhsach)
            {
                Console.WriteLine(i);
            }

        }
    }
}
