using Domain.ValueObjects;
using Domain.Entities;
namespace Application.DTOs
{
    public class AddStudentAttendanceDTO
    {
        public int StudentId { get; set; }
        public int AttendanceId { get; set; }
        public AttendanceStatus Status { get; set; }
    }
    public class GetStudentAttendanceDTO
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Attendance Attendance { get; set; }
        public int AttendanceId { get; set; }
        public AttendanceStatus Status { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}