using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IClasss
    {
        public Task<List<GetClasssDTO>> GetAllClasssAsync();
        Task AddClasssAsync(AddClasssDTO classs);
        public Task<GetClasssDTO?> GetClasssByIdAsync(int id);
        public Task UpdateClasssAsync(UpdateClasssDTO classs);
    }
}