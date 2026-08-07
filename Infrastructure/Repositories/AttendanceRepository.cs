using Application.DTOs;
using Application.Interfaces;
using Infrastructure.Data;
using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AttendanceRepository: IAttendance
    {
        private readonly ApplicationDbContext _dbcontext;
        public AttendanceRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<GetAttendanceDTO>> GetAllAttendancesAsync()
        {
            return await _dbcontext.Attendances
            .Include(a => a.Classs)
            
            .Select(a => new GetAttendanceDTO
            {
              Classs= a.Classs,
              Date = a.Date,
              Id = a.Id,
              ClasssId = a.ClasssId,
              DateAdded = a.DateAdded,

            }).ToListAsync();
        }
        public async Task AddAttendanceAsync(AddAttendanceDTO attendance)
        {
            await _dbcontext.Attendances.AddAsync(
                new Attendance
                {
                    InstructorName = attendance.InstructorName,
                    ClasssId = attendance.ClasssId,
                    Status = AttendanceStatus.Active,
                    Date = attendance.Date,
                    UserAdded = "Admin",
                    DateAdded = DateTime.UtcNow
                }

            );
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance)
        {
            ///Insert into attendance
            var attendanceEntity = new Attendance
            {
                ClasssId= attendance.ClasssId,
                InstructorName = attendance.InstructorName,
                Date = attendance.Date,
                UserAdded =attendance.InstructorName,
                DateAdded = DateTime.UtcNow,
                Status= AttendanceStatus.Active
            };
            await _dbcontext.Attendances.AddAsync(attendanceEntity);
            await _dbcontext.SaveChangesAsync();

            // -----------------------------END---------------------------
            //-----------------------------------FIND ACTIVE STUDENTS IN SELECTED-----------------------------------------

            var activeStudentIds = await _dbcontext.Registrations
            .Where(r => r.ClassId == attendance.ClasssId && r.Status == RegistrationStatus.Active)
            .Select(r => r.StudentId)
            .ToListAsync();
            //--------------------------------------------------------INSERT INTO STUDENT ATTENDANCE------------------------------------------

            var studentAttendanceEntity = activeStudentIds.Select(studentIds => new StudentAttendance
            {
               StudentId = studentIds,
               Attendance = attendanceEntity,
               Status = AttendanceStatus.UnTaken,
               DateAdded= DateTime.UtcNow,
               UserAdded= "Admin",
               
            }).ToList();
            await _dbcontext.StudentAttendances.AddRangeAsync(studentAttendanceEntity);
            await _dbcontext.SaveChangesAsync();
            //-------------------------------------------------------END---------------------------------------
            //----------------------------------------FETCH SAVE STUDENTATTENDANCES FOR ONLY ONE CLASS/ATTENDANCE----------------------

            return await _dbcontext.StudentAttendances
                .Include(sa => sa.Student)
                .Include(sa => sa.Attendance)
                .Where(sa => sa.AttendanceId == attendanceEntity.Id)
                .Select(sa => new GetStudentAttendanceDTO
                {
                    Id = sa.Id,
                    Student = sa.Student,
                    StudentId = sa.StudentId,
                    Attendance = sa.Attendance,
                    AttendanceId = sa.AttendanceId,
                    Status = sa.Status,
                    UserAdded = sa.UserAdded,
                    DateAdded = sa.DateAdded
                })
                .ToListAsync();
        }
    }
}