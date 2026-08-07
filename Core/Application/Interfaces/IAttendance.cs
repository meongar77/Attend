using Application.DTOs;
namespace Application.Interfaces
{
    public interface IAttendance
    {
        Task<List<GetAttendanceDTO>> GetAllAttendancesAsync();
        Task AddAttendanceAsync(AddAttendanceDTO attendance);
        Task<List<GetStudentAttendanceDTO>> AddAttendanceWithStudentAttendanceAsync(AddAttendanceDTO attendance);
    }
}