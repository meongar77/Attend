using Application.DTOs;
using Domain.Entities;
namespace Application.Interfaces
{
    public interface IFaculty
    {
        public Task<List<Faculty>> GetAllFacultiesAsync();
        
    }
}