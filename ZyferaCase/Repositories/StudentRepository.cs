using Microsoft.EntityFrameworkCore;
using ZyferaCase.Data;
using ZyferaCase.Interfaces;

namespace ZyferaCase.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context; 
        }

        public async Task<Student> CreateAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.AsNoTracking().ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _context.Students.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
