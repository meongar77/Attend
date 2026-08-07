using Application.DTOs;
using Application.Interfaces;
namespace Application.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendance _attendance;

        public AttendanceService(IAttendance attendance)
        {
            _attendance = attendance;
        }

        public async Task<List<GetAttendanceDTO>> GetAllAttendancesAsync()
        {
            return await _attendance.GetAllAttendancesAsync();
        }

        public async Task AddAttendanceAsync(AddAttendanceDTO attendance)
        {
            await _attendance.AddAttendanceAsync(attendance);
        }
        public async Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance)
        {
            return await _attendance.AddAttendanceWithStudentAttendanceAsync(attendance);
        }
    }
}