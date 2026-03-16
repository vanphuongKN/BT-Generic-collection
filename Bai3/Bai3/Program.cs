using System;
using System.Collections.Generic;

namespace Bai3
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
                Console.Write("Vui long nhap so nguyen hop le: ");
            }

            List<int> danhsach = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                int so;

                while (!int.TryParse(Console.ReadLine(), out so))
                {
                    Console.Write("Nhap lai so nguyen hop le: ");
                }

                danhsach.Add(so);
            }

            int max = danhsach[0];

            foreach (int so in danhsach)
            {
                if (so > max)
                    max = so;
            }

            Console.WriteLine("So lon nhat trong day la: " + max);
        }
    }
}