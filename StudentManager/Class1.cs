using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStudentManager
{
    public class StudentManager : IStudentManager
    {
        public List<Student> students;

        public StudentManager(List<Student> students)
        {
            Student firsStudent = new Student()
            {
                Id = 1,
                Name = "Dilara Sedef",
                Number = 0001,
            };
            students.Add(firsStudent);
            _students = students;
        }
        public List<Student> AddStudent(Student student)
        {
            _student.Add(student);
            return _student;
        }

        public void UpdateStudent(Student student)
        {
            foreach (var item in _students)
            {
                if (item.Id == student.Id)
                {
                    item.Name = student.Name;
                    item.Number = student.Number;
                }
            }
        }

        public void WriteStudents()
        {
            foreach (var student in _student)
            {
                Console.WriteLine($"Öğrenci adı: {student.Name}\nÖğrenci no:{student.Number}");
            }
        }
    }
}