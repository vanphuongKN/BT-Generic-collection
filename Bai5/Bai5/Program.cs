namespace Bai5
{
    internal class Program
    {
        static void indanhsach(List<string> list)
        {
            if (list.Count == 0) 
                Console.WriteLine("(Danh sach trong)");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<string> dssinhvien = new List<string> { "phuong","Nguyen", "thien","vien"};
            Console.Write("danh sach vien la: ");
            indanhsach(dssinhvien);
            Console.WriteLine("Nhap ten can xoa");
            string tencanxoa = Console.ReadLine();
            bool kq = dssinhvien.Remove(tencanxoa);
            if (kq)
                Console.WriteLine("Da xoa thanh cong " + tencanxoa);
            else
                Console.WriteLine("Khong tim thay ten sv:" + tencanxoa);
            Console.Write("in lai danh sach: ");
            indanhsach(dssinhvien);
            Console.ReadLine();
        }
    }
}
