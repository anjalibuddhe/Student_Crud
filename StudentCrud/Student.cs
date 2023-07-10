using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrud
{
    public class Student
    {
        public int rollNo { get; set; }
        public string name { get; set; }

        public string school { get; set; }
    }

    public class StudentCrud
    {
        private List<Student> students;

        public StudentCrud()
        {
            students =new List<Student>();
        }

        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }
        public List<Student> GetStudents()
        {
            return students;
        }

        public void UpdateStudent(Student stud)
        {
            foreach  (Student s1 in students)
            {
               if(s1.rollNo == stud.rollNo)
                {
                    s1.name = stud.name;
                    s1.school = stud.school;
                }
            }
        }

        public void DeleteStudent(int rollNo)
        {
            foreach (Student s1 in students)
            {
                if (s1.rollNo == rollNo)
                {
                    students.Remove(s1);
                }
            }
        }

    }
}
