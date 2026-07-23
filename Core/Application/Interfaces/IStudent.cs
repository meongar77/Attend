using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface IStudent
    {
         Task<List<GetStudentDTO>> GetAllStudentsAsync();
         Task AddStudentAsync(AddStudentDTO student);
         Task<GetStudentDTO?> GetStudentByIdAsync(int id);
         Task UpdateStudentAsync(UpdateStudentDTO student);
    }
}