

using DataAccess;

List<Student> studentsList = new List<Student>();


IStudentManager studentManager = new StudentManager(studentsList);

studentManager.AddStudent(new Student()
{
    Id = 2,
    Name = "Enes Zeren",
    Number = 002,
});

studentManager.AddStudent(new Student()
{
    Id = 3,
    Name = "Ahmet Güneş",
    Number = 003,
});



studentManager.UpdateStudent(new Student()
{
    Id = 1 ,
    Name ="Enes Öğretmen",
    Number = 001
});


studentManager.WriteStudents();