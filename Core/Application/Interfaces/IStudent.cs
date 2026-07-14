using Domain.Entities;
namespace Application.Interfaces
{
    public interface IStudent
    {
        public List<Student> GetAllStudents();
    }
}