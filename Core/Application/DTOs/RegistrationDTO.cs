using Domain.ValueObjects;
using Domain.Entities;
namespace Application.DTOs
{
    public class GetRegistrationDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RegistrationStatus Status { get; set; }
        public Student Student { get; set; } = null!;

        public Classs Class { get; set; } = null!;
    }
    public class AddRegistrationDTO
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Student Student { get; set; } = null!;

        public Classs Class { get; set; } = null!;
    }
    public class UpdateRegistrationDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RegistrationStatus Status { get; set; }
        public Student Student { get; set; } = null!;

        public Classs Class { get; set; } = null!;
    }
    public class DeleteRegistrationDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}