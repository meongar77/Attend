using Domain.Entities;
namespace Application.Services.StudentServices
{
    public class StudentService:IStudentService
    {
        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student{Id=1, Name="Louis BIKORIMANA", Sex="Female",Phone="078958595", DateOfBirth= new DateTime(2000,5,1), Email="bikorimana@gmail.com"},
                new Student{Id=2, Name="Louis BIKORIMANA", Sex="Female",Phone="078958595", DateOfBirth= new DateTime(2000,5,1), Email="bikorimana@gmail.com"}
            };
        }
    }
    
}