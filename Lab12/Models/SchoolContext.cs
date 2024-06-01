using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Lab12.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet <Student> Students{ get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-27\\SQLEXPRESS;Initial Catalog=taipedb;User ID=userTaipe;Password=12345; Integrated Security=True; trustservercertificate=True");
        }

    }
}
