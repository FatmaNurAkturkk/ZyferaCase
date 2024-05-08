using Microsoft.EntityFrameworkCore;

namespace ZyferaCase.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Grades)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student {Id = 1, Name = "Ali", Surname = "Yılmaz", StudentNumber = "B012X00012"},
            });

            modelBuilder.Entity<Grade>().HasData(new Grade[]
            {
                new Grade {Id = 1, StudentId = 1, Code = "MT101", Value = 90},
                new Grade {Id = 2, StudentId = 1, Code = "PH101", Value = 75},
                new Grade {Id = 3, StudentId = 1, Code = "CH101", Value = 60},
                new Grade {Id = 4, StudentId = 1, Code = "MT101", Value = 70},
                new Grade {Id = 5, StudentId = 1, Code = "HS101", Value = 65},
            });
        }

    }
}
