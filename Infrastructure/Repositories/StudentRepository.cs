using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public async Task<List<GetStudentDTO>> GetAllStudentsAsync()
        {
            return await _dbcontext.Students.Select(s => new GetStudentDTO
            {
                Id = s.Id,
                Name = s.Name,
                Address=s.Address,
                DateOfBirth = s.DateOfBirth,
                Sex = s.Sex,
                Phone= s.Phone,
                Email = s.Email
            }).ToListAsync();
        }
        public async Task AddStudentAsync(AddStudentDTO student)
        {
            
            _dbcontext.Students.Add(new Student{
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Phone= student.Phone,
                Email = student.Email,
                Sex= student.Sex,
            });
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<GetStudentDTO?> GetStudentByIdAsync(int id)
        {
            return await _dbcontext.Students.Where(s => s.Id == id).Select(s=> new GetStudentDTO
            {
                Id = s.Id,
                Name = s.Name,
                Address=s.Address,
                DateOfBirth = s.DateOfBirth,
                Sex = s.Sex,
                Phone= s.Phone,
                Email = s.Email
            }).FirstOrDefaultAsync();
        }
        public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
            var existingStudent = await _dbcontext.Students.FirstOrDefaultAsync(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Sex = student.Sex;
                existingStudent.DateOfBirth = student.DateOfBirth;
                existingStudent.Address = student.Address;
                existingStudent.Phone = student.Phone;

                await _dbcontext.SaveChangesAsync();
            }

            
        }
    }
}