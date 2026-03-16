using System;
using System.Collections.Generic;

namespace Bai2
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
                Console.Write("nhap so nguyen hop le: ");
            }

            List<int> danhSach = new List<int>();

            Console.WriteLine("Nhap cac so nguyen:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so {i + 1}: ");
                int so;

                while (!int.TryParse(Console.ReadLine(), out so))
                {
                    Console.Write("Nhap lai so nguyen: ");
                }

                danhSach.Add(so);
            }

            int tong = 0;

            foreach (int so in danhSach)
            {
                tong += so;
            }

            Console.WriteLine("Tong cua day so la: " + tong);
        }
    }
}