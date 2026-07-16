namespace Domain.Entities
{
    public class Faculty
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public ICollection<Classs> classses {get;set;}
    }
}