using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student{Id=1, Name="John Doe", Sex="Male", DateOfBirth= new DateTime(2000,1,1), Phone="1234567890", Email="johndoe@example.com"},
                new Student{Id=2, Name="Jane Smith", Sex="Female", DateOfBirth= new DateTime(2001,2,2), Phone="0987654321", Email="janesmith@example.com"}
            };
        }
    }
}