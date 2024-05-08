using System.Diagnostics;

namespace ZyferaCase.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNumber { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
