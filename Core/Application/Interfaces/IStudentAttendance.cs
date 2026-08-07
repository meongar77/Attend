using Application.DTOs;
using Domain.ValueObjects;
namespace Application.Interfaces
{
    public interface IStudentAttendance
    {
        Task<List<GetStudentAttendanceDTO>> GetAllStudentAttendancesAsync();
        // -----------------------------CHANGE :: CHANGE IN THE BRACKET(PARAMETER) FROM AddStudentAttendanceDTO to 
        // 1. StudentAttendanceId but I called it AttendanceId
        // 2. StudenAttendanceStatus 
        Task AddStudentAttendanceAsync(int AttendanceId, AttendanceStatus Status);
    }
}