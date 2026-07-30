using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IEducationLevel
    {
        public Task<List<EducationLevel>> GetAllEducationLevelsAsync();
        
    }
}