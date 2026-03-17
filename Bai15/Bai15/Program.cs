namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong"); 

            var tudien = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"hello", "xin chao"},
                {"book", "quyen sach"},
                {"computer", "may tinh"},
                {"school", "truong hoc"}
            };

            while (true)
            {
                Console.Write("Nhap tu: ");
                string tu = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(tu))
                {
                    Console.WriteLine("Ban chua nhap tu!");
                    continue;
                }

                if (tu.ToLower() == "exit") break;

                if (tudien.TryGetValue(tu, out string nghia))
                    Console.WriteLine($"=> {nghia}");
                else
                    Console.WriteLine("Khong tim thay!");
            }
        }
    }
}