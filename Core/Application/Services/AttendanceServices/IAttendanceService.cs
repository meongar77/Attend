using Application.DTOs;
namespace Application.Services.AttendanceServices
{
    public interface IAttendanceService
    {
        Task<List<GetAttendanceDTO>> GetAllAttendancesAsync();
        Task AddAttendanceAsync(AddAttendanceDTO attendance);
        Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance);
    }
}