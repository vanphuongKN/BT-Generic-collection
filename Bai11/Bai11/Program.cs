namespace Bai11
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
            Student sv1= new Student();
            sv1.Id = 1;
            sv1.Name = "Vo Van Phuong";

            Student sv2 = new Student();
            sv2.Id = 2;
            sv2.Name = "Vo Thi quynh duyen";
            danhsachsinhvien.Add(sv1);
            danhsachsinhvien.Add(sv2);
            foreach(Student sv in danhsachsinhvien)
            {
                Console.WriteLine("Ma sv:" + sv.Id+ " Ho ten: " + sv.Name);

            }
        }
    }
}
