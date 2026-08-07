using Application.Interfaces;
using Domain.ValueObjects;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.DTOs;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class StudentAttendanceRepository: IStudentAttendance
    {
        private readonly ApplicationDbContext _context;
        public StudentAttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync()
        {
            return await _context.StudentAttendances
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendance)
                .Select(sa => new GetStudentAttendanceDTO
                {
                    Id = sa.Id,
                    Student = sa.Student,
                    StudentId = sa.StudentId,
                    Attendance = sa.Attendance,
                    AttendanceId = sa.AttendanceId,
                    Status = sa.Status,
                    DateAdded = sa.DateAdded,
                    UserAdded = sa.UserAdded
                }).ToListAsync();
        }     


        // THIS WAS CHANGED FROM ADDing NEW ATTENDANCE RECORD TO UPDATING ATTENDANCESTATUS 

        public async Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status)
        {
            var existing = await _context.StudentAttendances.FindAsync(AttendanceId);
           if (existing == null)
            {
                throw new InvalidOperationException("Student attendance record not found.");
            }
            existing.Status = status;
            await _context.SaveChangesAsync();
        }
    }
}