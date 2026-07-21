using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.StudentServices
{
    public class StudentService:IStudentService
    {
        private readonly IStudent _student;
        public StudentService(IStudent student)
        {
            _student=student;
        }
        public List<GetStudentDTO> GetAllStudents()
        {
           return _student.GetAllStudents();
        }
        public void AddStudent(AddStudentDTO student)
        {
            _student.AddStudent(student);
            
        }
        public GetStudentDTO? GetStudentById(int id)
        {
            return _student.GetStudentById(id);
        }
        public void UpdateStudent(UpdateStudentDTO student)
        {
            _student.UpdateStudent(student);
        }
    }
    
}
            