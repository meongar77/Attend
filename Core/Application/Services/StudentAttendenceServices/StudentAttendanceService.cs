using Application.DTOs;
using Application.Interfaces;
using Domain.ValueObjects;
namespace Application.Services.StudentAttendanceServices
{
    public class StudentAttendanceService : IStudentAttendanceService
    {
        private readonly IStudentAttendance _studentAttendance;

        public StudentAttendanceService(IStudentAttendance studentAttendance)
        {
            _studentAttendance = studentAttendance;
        }

        public async Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync()
        {
            return await _studentAttendance.GetAllStudentAttendancesAsync();
        }
        // ------------------------CHANGES
        public async Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status)
        {
            await _studentAttendance.AddStudentAttendanceAsync(AttendanceId, status);
        }
    }
}