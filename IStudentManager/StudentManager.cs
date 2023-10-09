using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentManager : IStudentManager
    {
        private List<Student> _students;

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
            _students.Add(student);
            return _students;
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
            foreach (var student in _students)
            {
                Console.WriteLine($"Öğrenci adı: {student.Name}\nÖğrenci no:{student.Number}");
            }
        }
    }
}