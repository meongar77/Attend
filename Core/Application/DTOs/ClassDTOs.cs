namespace Application.DTOs{
    public class AddClasssDTO
    {
        
        public string Name{get;set;}
        public int FacultyId{get;set;}
        public int EducationLevelId{get;set;}
    }
    public class UpdateClasssDTO
    {
        public int Id {get;set;}
       public string Name{get;set;}
        public int FacultyId{get;set;}
        public int EducationLevelId{get;set;}
    }
    public class GetClasssDTO
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public int FacultyId{get;set;}
        public int EducationLevelId{get;set;}
    }
}