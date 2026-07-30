using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.EducationLevelServices
{
    public class EducationLevelService:IEducationLevelService
    {
        private readonly IEducationLevel _educationLevel;
        public EducationLevelService(IEducationLevel educationLevel)
        {
            _educationLevel=educationLevel;
        }
        public async Task<List<EducationLevel>> GetAllEducationLevelsAsync()
        {
           return await _educationLevel.GetAllEducationLevelsAsync();
        }
        
    }
    
}
            