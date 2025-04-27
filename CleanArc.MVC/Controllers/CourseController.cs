using Microsoft.AspNetCore.Mvc;
using CleanArc.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace CleanArc.MVC.Controllers;

[Authorize]
public class CourseController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICourseService _courseService;

    public CourseController(ILogger<HomeController> logger, ICourseService courseService)
    {
        _logger = logger;
        _courseService = courseService;
    }

    public IActionResult Index()
    {
        var model = _courseService.GetCourses();
        return View(model);
    }


}
