using Domain.Entities;
using Application.DTOs;
namespace Application.Services.StudentServices
{
    public interface IStudentService
    {
         Task<List<GetStudentDTO>> GetAllStudentsAsync();
         Task AddStudentAsync(AddStudentDTO student);
         Task<GetStudentDTO?> GetStudentByIdAsync(int id);
         Task UpdateStudentAsync(UpdateStudentDTO student);
    }
}