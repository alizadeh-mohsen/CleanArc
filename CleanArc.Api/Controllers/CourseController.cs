using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.CreateCourse(courseViewModel);
            return Ok(courseViewModel);
        }
    }
}
