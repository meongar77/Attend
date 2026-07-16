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
    }
}