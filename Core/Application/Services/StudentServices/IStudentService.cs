using Domain.Entities;
using Application.DTOs;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
        public List<GetStudentDTO> GetAllStudents();
        public void AddStudent(AddStudentDTO student);
        public  GetStudentDTO? GetStudentById(int id);
        public void UpdateStudent(UpdateStudentDTO student);
    }
}