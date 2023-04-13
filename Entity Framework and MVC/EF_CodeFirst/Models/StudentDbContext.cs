using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Models;

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }

    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Student student1 = new Student() { StudentID = 1, StudentName = "Mićo Odlikaš", DateofBirth = new DateTime (2003, 01, 22), Weight = 89, Height = 182};
        Student student2 = new Student() { StudentID = 2, StudentName = "Mićo Vrlodobraš", DateofBirth = new DateTime (2003, 05, 12), Weight = 95, Height = 180};

        Grade grade1 = new Grade() { GradeId = 101, GradeName = "B", Section = "Section 1", StudentId = 1 };
        Grade grade2 = new Grade() { GradeId = 102, GradeName = "A", Section = "Section 1", StudentId = 1 };
        Grade grade3 = new Grade() { GradeId = 103, GradeName = "A", Section = "Section 2", StudentId = 1 };
        Grade grade4 = new Grade() { GradeId = 104, GradeName = "D", Section = "Section 2", StudentId = 2 };
        Grade grade5 = new Grade() { GradeId = 105, GradeName = "A", Section = "Section 2", StudentId = 2 };
        Grade grade6 = new Grade() { GradeId = 106, GradeName = "C", Section = "Section 3", StudentId = 2 };
        Grade grade7 = new Grade() { GradeId = 107, GradeName = "B", Section = "Section 3", StudentId = 2 };

        modelBuilder.Entity<Student>().HasData(student1, student2);
        modelBuilder.Entity<Grade>().HasData(grade1, grade2, grade3, grade4, grade5, grade6, grade7);
    }
}
