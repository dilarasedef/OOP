using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStudentManager
    {
        public void WriteStudents();
        public List<Student> AddStudent(Student student);
        public void UpdateStudent(Student student);

    }
}