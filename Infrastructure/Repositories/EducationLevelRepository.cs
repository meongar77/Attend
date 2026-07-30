using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository : IEducationLevel
    {
        private readonly ApplicationDbContext _dbcontext;
        public EducationLevelRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public async Task<List<EducationLevel>> GetAllEducationLevelsAsync()
        {
            return await _dbcontext.EducationLevels.ToListAsync();
        }
    }
}