using Domain.ValueObjects;
namespace Domain.Entities{
    public class Registration{
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public RegistrationStatus Status { get; set; }

        // Relationship
        public Student Student { get; set; } = null!;

        public Classs Class { get; set; } = null!;
    }
}
