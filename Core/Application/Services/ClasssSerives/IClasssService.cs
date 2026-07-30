using Domain.Entities;
using Application.DTOs;
namespace Application.Services.ClasssServices
{
    public interface IClasssService
    {
         Task<List<GetClasssDTO>> GetAllClasssAsync();
         Task AddClasssAsync(AddClasssDTO classs);
         Task<GetClasssDTO?> GetClasssByIdAsync(int id);
         Task UpdateClasssAsync(UpdateClasssDTO classs);
    }
}