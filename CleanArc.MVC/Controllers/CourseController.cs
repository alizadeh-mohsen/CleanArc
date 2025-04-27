using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CleanArc.MVC.Models;
using CleanArc.Application.Interfaces;

namespace CleanArc.MVC.Controllers;

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
