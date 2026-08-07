using Domain.Entities;
using Domain.ValueObjects;

namespace Application.DTOs
{
    public class AddAttendanceDTO
    {
        public string InstructorName { get; set; }
        public DateTime Date { get; set; }
        public int ClasssId { get; set; }
        public AttendanceStatus Status { get; set; }

    }
    public class GetAttendanceDTO
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
        public Classs Classs { get; set; }
        public int ClasssId { get; set; }
        public AttendanceStatus Status { get; set; }
        public DateTime Date { get; set; }

        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
    public class UpdateAttendanceDTO
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
        public AttendanceStatus Status { get; set; }
        public DateTime Date { get; set; }
        public int ClasssId { get; set; }
    }
    public class DeleteAttendanceDTO
    {
        public int Id { get; set; }
        public AttendanceStatus Status { get; set; }
    }
}