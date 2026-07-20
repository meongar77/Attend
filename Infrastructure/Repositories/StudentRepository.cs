using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }


        public List<Student> GetAllStudents()
        {
            return _dbcontext.Students.ToList();
        }
        public void AddStudent(Student student)
        {
            _dbcontext.Students.Add(student);
            _dbcontext.SaveChanges();
        }
        public Student? GetStudentById(int id)
        {
            return _dbcontext.Students.FirstOrDefault(tt => tt.Id == id);
        }
    }
}