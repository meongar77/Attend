namespace Application.DTOs{
    public class AddStudentDTO
    {
        public string Name{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Sex {get;set;}
        public string Address {get;set;}
        public string Phone{get;set;}
        public string Email {get;set;}
    }
    public class UpdateStudentDTO
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Address{get;set;}
        public string Sex{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
    }
    public class GetStudentDTO
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public string Address{get;set;}
        public string Sex{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Adress{get;set;}
    }
}