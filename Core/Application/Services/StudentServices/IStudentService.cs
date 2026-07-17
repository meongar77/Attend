using Domain.Entities;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);
    }
}