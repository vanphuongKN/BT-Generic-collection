using System;
using System.Collections.Generic;

namespace Bai18
{
    internal class Program
    {
        public class Student
        {
            public string Name;
            public double Score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            int n;
            Console.Write("Nhap so sinh vien: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhap so hop le: ");
            }

            List<Student> danhsach = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();

                Console.Write($"Nhap ten sinh vien {i + 1}: ");
                sv.Name = Console.ReadLine();

                Console.Write($"Nhap diem sinh vien {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out sv.Score))
                {
                    Console.Write("Nhap diem hop le: ");
                }

                danhsach.Add(sv);
            }

            Student svMax = danhsach[0];

            foreach (Student sv in danhsach)
            {
                if (sv.Score > svMax.Score)
                {
                    svMax = sv;
                }
            }

            Console.WriteLine("\nSinh vien co diem cao nhat:");
            Console.WriteLine($"Ten: {svMax.Name} - Diem: {svMax.Score}");
        }
    }
}