using ZyferaCase.Data;

namespace ZyferaCase.Interfaces
{
    public interface IStudentRepository
    {

        public Task<Student> CreateAsync(Student product);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetByIdAsync(int id);
    }
}
