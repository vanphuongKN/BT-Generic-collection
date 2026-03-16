namespace Bai12
{
    internal class Program
    {
        public class Student
        {
            public int Id;
            public string Name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            List<Student> danhsachsinhvien = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();

                Console.Write($"Nhap ID sinh vien {i + 1}: ");
                sv.Id = int.Parse(Console.ReadLine());

                Console.Write($"Nhap ten sinh vien {i + 1}: ");
                sv.Name = Console.ReadLine();

                danhsachsinhvien.Add(sv);
            }
            Console.Write("Nhap ten sinh vien can tim: ");
            string tenCanTim = Console.ReadLine();

            foreach (Student sv in danhsachsinhvien)
            {
                if (sv.Name.ToLower() == tenCanTim.ToLower())
                {
                    Console.WriteLine($"ID: {sv.Id} - Ten: {sv.Name}");
                   
                }
            }
           

        }
    }
}
