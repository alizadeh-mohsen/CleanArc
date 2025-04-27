using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using CleanArc.Domain.Commands;
using CleanArc.Domain.Core.Bus;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            var createCommand = new CreateCourseCommand(
                    courseViewModel.Title,
                    courseViewModel.Description,
                    courseViewModel.Image);
         
            _bus.SendCommand(createCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }

    }
}
