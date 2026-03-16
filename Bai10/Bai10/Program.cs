namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<int> danhSach = new List<int> { 45, 12, 56, 8, 23, 99 };
            int soNhoNhat = danhSach[0];
            for (int i = 1; i < danhSach.Count; i++)
            {
                int soHienTai = danhSach[i];
                if(soHienTai <  soNhoNhat)
                    soNhoNhat = soHienTai;

            }
            Console.WriteLine("gia tri nho nhat trong danh sach: " + soNhoNhat);

        }
    }
}
