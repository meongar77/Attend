using Domain.Entities;
using Application.DTOs;
namespace Application.Services.EducationLevelServices
{
    public interface IEducationLevelService
    {
        Task<List<EducationLevel>> GetAllEducationLevelsAsync();    
    }
}