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

            List<Student> danhsachsinhvien = new List<Student>();
            Student sv1 = new Student();
            sv1.Id = 1;
            sv1.Name = "Vo Van Phuong";
            danhsachsinhvien.Add(sv1);

            Student sv2 = new Student();
            sv2.Id = 2;
            sv2.Name = "Vo Thi Quynh Duyen";
            danhsachsinhvien.Add(sv2);

            Student sv3 = new Student();
            sv3.Id = 3;
            sv3.Name = "Nguyen Van A";
            danhsachsinhvien.Add(sv3);
            Console.Write("Nhap ten sinh vien can tim: ");
            string tenCanTim = Console.ReadLine();
            bool daTimThay = false;
            foreach (Student sv in danhsachsinhvien)
            {
                if(sv.Name.ToLower().Contains(tenCanTim.ToLower()))
                {
                    Console.WriteLine("Ma sv: " + sv.Id + " Ho ten: " + sv.Name);
                    daTimThay = true;
                }    

            }
            if (daTimThay == false)
            {
                Console.WriteLine("khong tim thay ");
            }


        }
    }
}
