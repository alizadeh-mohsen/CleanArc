using CleanArc.Application.ViewModels;

namespace CleanArc.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void CreateCourse(CourseViewModel courseViewModel);
    }
}
