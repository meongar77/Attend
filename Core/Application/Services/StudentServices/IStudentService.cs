using Domain.Entities;
using Application.DTOs;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public void AddStudent(AddStudentDTO student);
        public  Student? GetStudentById(int id);
        public void UpdateStudent(Student student);
    }
}