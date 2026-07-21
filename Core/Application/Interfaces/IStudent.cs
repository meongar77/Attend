using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IStudent
    {
        public List<Student> GetAllStudents();
        public void AddStudent(AddStudentDTO student);
        public Student? GetStudentById(int id);
        public void UpdateStudent(Student student);
    }
}