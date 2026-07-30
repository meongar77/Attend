using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ClasssRepository : IClasss
    {
        private readonly ApplicationDbContext _dbcontext;
        public ClasssRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public async Task<List<GetClasssDTO>> GetAllClasssAsync()
        {
            return await _dbcontext.Classses.Select(c => new GetClasssDTO
            {
                Id = c.Id,
                Name = c.Name,
                FacultyId = c.FacultyId,
                EducationLevelId = c.EducationLevelId
            }).ToListAsync();
        }
        public async Task AddClasssAsync(AddClasssDTO classs)
        {
            
            _dbcontext.Classses.Add(new Classs{
                Name = classs.Name,
                FacultyId = classs.FacultyId,
                EducationLevelId = classs.EducationLevelId,
                
            });
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<GetClasssDTO?> GetClasssByIdAsync(int id)
        {
            return await _dbcontext.Classses.Where(c => c.Id == id).Select(c=> new GetClasssDTO
            {
                Id = c.Id,
                Name = c.Name,
                FacultyId = c.FacultyId,
                EducationLevelId = c.EducationLevelId
            }).FirstOrDefaultAsync();
        }
        public async Task UpdateClasssAsync(UpdateClasssDTO classs)
        {
            var existingClasss = await _dbcontext.Classses.FirstOrDefaultAsync(c => c.Id == classs.Id);
            if (existingClasss != null)
            {
                existingClasss.Name = classs.Name;
                existingClasss.FacultyId = classs.FacultyId;
                existingClasss.EducationLevelId = classs.EducationLevelId;

                await _dbcontext.SaveChangesAsync();
            }

            
        }
    }
}