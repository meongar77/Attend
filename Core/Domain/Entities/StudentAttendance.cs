using Domain.ValueObjects;
namespace Domain.Entities
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public AttendanceStatus Status { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }

        //Prefic should match the Navigation property name
        public int StudentId { get; set; }
        public int AttendanceId { get; set; }

        //Nagivation properties
        public Student Student { get; set; }
        public Attendance Attendance { get; set; }

    }
}