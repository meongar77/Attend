namespace Domain.Entities{
    public class StudentClass{
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime CreatedAt { get; set; }

        // Relationship
        public Student Student { get; set; }
        
        public Classs Class { get; set; }
    }
}
