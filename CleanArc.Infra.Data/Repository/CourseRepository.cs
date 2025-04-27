using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using CleanArc.Infra.Data.Context;

namespace CleanArc.Infra.Data.Repository
{
    public class CourseRepository: ICourseRepository
    {
        private readonly UniversityDbContext _universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }

    }
}
