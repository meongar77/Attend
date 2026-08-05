using Application.DTOs;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Domain.ValueObjects;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class RegistrationRepository:IRegistration
    {
        private readonly ApplicationDbContext _context;
        public RegistrationRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<List<GetRegistrationDTO>> GetAllRegistrationsAsync()
        {
            return await _context.Registrations
            .Include(r => r.Student)
            .Include(r => r.Class)
            .Select(c => new GetRegistrationDTO
            {
                Id = c.Id,
                ClassId= c.ClassId,
                StartDate=c.StartDate,
                EndDate=c.EndDate,
                StudentId = c.StudentId,
                Status = RegistrationStatus.Active,
                Student = c.Student,
                Class = c.Class,

            })
            .ToListAsync();
        }
        public async Task<GetRegistrationDTO?> GetRegistrationByIdAsync(int id)
        {
             return await _context.Registrations
             .Include(r => r.Student)
             .Include(r => r.Class)
             .Where(r=> r.Id == id)
             .Select(r => new GetRegistrationDTO
             {
                Id= r.Id,
                ClassId= r.ClassId,
                StudentId = r.StudentId,
                Status= r.Status,
                StartDate = r.StartDate,
                EndDate = r.EndDate,
                Student = r.Student,
                Class = r.Class,
             }).FirstOrDefaultAsync();

        }
        public async Task AddRegistrationAsync(AddRegistrationDTO registration)
        {
            var alreadyExists = await _context.Registrations
                .AnyAsync(r => r.ClassId == registration.ClassId && r.StudentId == registration.StudentId);

            if (alreadyExists)
            {
                throw new InvalidOperationException("This student is already registered in the selected class.");
            }

            await _context.Registrations.AddAsync(new Registration
            {
                ClassId=registration.ClassId,
                StudentId=registration.StudentId,
                StartDate=registration.StartDate,
                EndDate=registration.EndDate,
                Status= RegistrationStatus.Active,
            });
            await _context.SaveChangesAsync();
        }
    }
}