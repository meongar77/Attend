using Application.DTOs;
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

        public List<GetStudentDTO> GetAllStudents()
        {
            return _dbcontext.Students.Select(s => new GetStudentDTO
            {
                Id = s.Id,
                Name = s.Name,
                Address=s.Address,
                DateOfBirth = s.DateOfBirth,
                Sex = s.Sex,
                Phone= s.Phone,
                Email = s.Email,
            }).ToList();
        }
        public void AddStudent(AddStudentDTO student)
        {
            
            _dbcontext.Students.Add(new Student{
                Name = student.Name,
                DateOfBirth = student.DateOfBirth,
                Address = student.Address,
                Phone= student.Phone,
                Email = student.Email,
                Sex= student.Sex,
            });
            _dbcontext.SaveChanges();
        }
        public GetStudentDTO? GetStudentById(int id)
        {
            return _dbcontext.Students.Where(s => s.Id == id).Select(s=> new GetStudentDTO
            {
                Id = s.Id,
                Name = s.Name,
                Address=s.Address,
                DateOfBirth = s.DateOfBirth,
                Sex = s.Sex,
                Phone= s.Phone,
                Email = s.Email
            }).FirstOrDefault();
        }
        public void UpdateStudent(UpdateStudentDTO student)
        {
            // _dbcontext.Students.Update(student);
            // _dbcontext.SaveChanges();

             var ExistingStudent =  _dbcontext.Students.FirstOrDefault(s => s.Id == student.Id);
             if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.DateOfBirth = student.DateOfBirth;
                ExistingStudent.Address = student.Address;
                ExistingStudent.Phone = ExistingStudent.Phone;

                _dbcontext.SaveChanges();
            }


        }
    }
}