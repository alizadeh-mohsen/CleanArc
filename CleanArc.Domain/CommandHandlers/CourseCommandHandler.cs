using CleanArc.Domain.Commands;
using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using MediatR;

namespace CleanArc.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            _courseRepository.Add(new Course
            {
                Title = request.Title,
                Description = request.Description,
                Image = request.Image
            });

            return Task.FromResult(true);
        }
    }
}
