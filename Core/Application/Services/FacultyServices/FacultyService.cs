using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.FacultyServices
{
    public class FacultyService:IFacultyService
    {
        private readonly IFaculty _faculty;
        public FacultyService(IFaculty faculty  )
        {
            _faculty=faculty;
        }
        public async Task<List<Faculty>> GetAllFacultiesAsync()
        {
           return await _faculty.GetAllFacultiesAsync();
        }
        
    }
    
}
            