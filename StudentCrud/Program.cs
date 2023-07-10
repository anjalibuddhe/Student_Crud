using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCrud studentCrud = new StudentCrud();
            int option = 0;
            do
            {


                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Display All Products");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Student student = new Student();
                        Console.WriteLine("Enter Roll Number");
                        student.rollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student name");
                        student.name=Console.ReadLine();
                        Console.WriteLine("Enter school name");
                        student.school=Console.ReadLine();

                        studentCrud.AddStudent(student);

                        break;
                    case 2:
                        Student student1 = new Student();
                        Console.WriteLine("Enter new Roll No ");
                        student1.rollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Updated Name");
                        student1.name = Console.ReadLine();
                        Console.WriteLine("Enter Updated School name");
                        student1.school=Console.ReadLine();
                        studentCrud.UpdateStudent(student1);
                        break;
                    case 3:
                        Console.WriteLine("Enter roll No. To delete Record");
                        int rollNo = Convert.ToInt32(Console.ReadLine());
                        studentCrud.DeleteStudent(rollNo);
                        break
;
                    case 4:
                        List<Student> students = studentCrud.GetStudents();
                        foreach(Student s in students){
                            Console.WriteLine($"{s.rollNo}-{s.name}-{s.school}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 to Continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);

            }
    }
}
