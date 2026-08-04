using Domain.Entities;
using Application.DTOs;
namespace Application.Services.FacultyServices
{
    public interface IFacultyService
    {
        Task<List<Faculty>> GetAllFacultiesAsync();    
    }
}