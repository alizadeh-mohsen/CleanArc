using CleanArc.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infra.Data
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }
        //create a DbSet for each entity in the database
        public DbSet<Course> Courses { get; set; }
    }
}
