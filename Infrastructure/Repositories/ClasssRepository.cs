using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Domain.ValueObjects;
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
            return await _dbcontext.Classses
            .Include(c => c.Faculty)
            .Include(c => c.EducationLevel)
            .Select(c => new GetClasssDTO
            {
                Id = c.Id,
                Name = c.Name,
                Faculty = c.Faculty,
                EducationLevel = c.EducationLevel,
                FacultyId = c.FacultyId,
                EducationLevelId = c.EducationLevelId,
                Status = c.Status
            }).ToListAsync();
        }
        public async Task AddClasssAsync(AddClasssDTO classs)
        {
            var existingclass =  await _dbcontext.Classses.AnyAsync(c => c.Name == classs.Name && c.FacultyId == classs.FacultyId && c.EducationLevelId == classs.EducationLevelId);
            if(existingclass)
            {
                throw new InvalidOperationException("A class with the same name and level already exists.");
            }            
            _dbcontext.Classses.Add(new Classs{
                Name = classs.Name,
                FacultyId = classs.FacultyId,
                EducationLevelId = classs.EducationLevelId,
                Status = ClassStatus.Active
            });
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<GetClasssDTO?> GetClasssByIdAsync(int id)
        {
            return await _dbcontext.Classses
            .Include(c => c.Faculty)
            .Include(c => c.EducationLevel)
            .Where(c => c.Id == id)
            .Select(c=> new GetClasssDTO
            {
                Id = c.Id,
                Name = c.Name,
                Faculty = c.Faculty,
                EducationLevel = c.EducationLevel,
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
        public async Task<List<GetClassStatusCountDTO>> GetClassStatusCountAsync()
        {
           return await _dbcontext.Classses
           .GroupBy(c => c.Status)
           .Select(c => new GetClassStatusCountDTO
           {
               Status = c.Key,
               Count = c.Count()
           })
           .ToListAsync();
        }
    }
}