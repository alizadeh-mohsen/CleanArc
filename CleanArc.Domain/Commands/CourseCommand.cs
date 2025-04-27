using CleanArc.Domain.Core.Commands;

namespace CleanArc.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

    }
}
