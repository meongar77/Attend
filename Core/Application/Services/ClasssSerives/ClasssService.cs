using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.ClasssServices
{
    public class ClasssService:IClasssService
    {
        private readonly IClasss _classs;
        public ClasssService(IClasss classs)
        {
            _classs=classs;
        }
        public async Task<List<GetClasssDTO>> GetAllClasssAsync()
        {
           return await _classs.GetAllClasssAsync();
        }
        public async Task AddClasssAsync(AddClasssDTO classs)
        {
            await _classs.AddClasssAsync(classs);
        }
        public async Task<GetClasssDTO?> GetClasssByIdAsync(int id)
        {
            return await _classs.GetClasssByIdAsync(id);
        }
        public async Task UpdateClasssAsync(UpdateClasssDTO classs)
        {
            await _classs.UpdateClasssAsync(classs);
        }
        public async Task<List<GetClassStatusCountDTO>> GetClassStatusCountAsync()
        {
            return await _classs.GetClassStatusCountAsync();
        }
    }
    
}
            