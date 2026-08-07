using Application.DTOs;
using Domain.ValueObjects;
namespace Application.Services.StudentAttendanceServices
{
    public interface IStudentAttendanceService
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();

        //-----------------------CHANGES
        Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus status);
    }
}