namespace Domain.Entities
{
    public class EducationLevel
    {
        public int Id{get;set;}
        public string Name{get;set;}

        //Navigation Property: One Education Level can have many Classes
        public ICollection<Classs> classses{get;set;}
    }
}