using Microsoft.AspNetCore.Mvc;
using ZyferaCase.Data;
using ZyferaCase.Interfaces;
using ZyferaCase.Repositories;

namespace ZyferaCase.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentRepository.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _studentRepository.GetByIdAsync(id);
            if (data == null)
            {
                return NotFound(id);
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var addedStudent = await _studentRepository.CreateAsync(student);
            return Created(string.Empty, addedStudent);
        }
    }
}
