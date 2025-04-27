using CleanArc.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infra.Data.Context
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
