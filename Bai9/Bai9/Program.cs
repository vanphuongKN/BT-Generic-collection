namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSV: 2415053122230");
            Console.WriteLine("Vo Van Phuong");

            List<int> danhsach = new List<int>() { 1,4,5,1,2,5,9};
            List<int> danhsachMoi = new List<int>();
            for(int i = 0; i < danhsach.Count; i++)
            {
                int sohientai = danhsach[i];
                if(danhsachMoi.Contains(sohientai) == false)
                    danhsachMoi.Add(sohientai);
            }
            Console.WriteLine("danh sach sau khi kiem tra trung lap: ");
            for (int i = 0; i < danhsachMoi.Count; i++)
            {
                Console.Write(danhsachMoi[i] + " ");
            }

        }
    }
}
