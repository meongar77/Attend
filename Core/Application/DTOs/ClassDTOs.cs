
using Domain.Entities;
using Domain.ValueObjects;

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
        public ClassStatus Status{get;set;}
        public Faculty Faculty{get;set;}
        public EducationLevel EducationLevel{get;set;}
    }
    public class GetClassStatusCountDTO
    {
        public ClassStatus Status{get; set;}
        public int Count{get;set;}
    }
}