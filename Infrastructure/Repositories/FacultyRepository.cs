using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class FacultyRepository : IFaculty
    {
        private readonly ApplicationDbContext _dbcontext;
        public FacultyRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public async Task<List<Faculty>> GetAllFacultiesAsync()
        {
            return await _dbcontext.Faculties.ToListAsync();
        }
    }
}