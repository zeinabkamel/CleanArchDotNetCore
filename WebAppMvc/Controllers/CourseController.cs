using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanWebApp.Application.Interfaces;
using CleanWebApp.Application.Services;
using CleanWebApp.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Controllers
{
    public class CourseController : Controller
    {
      private  ICourseService _CourseServices;
        public CourseController(ICourseService courseService)
        {
            this._CourseServices = courseService;

        }

        public IActionResult Index()
        {
        CourseViewModel courseViewModel= _CourseServices.GetCourses();
            return View(courseViewModel);
        }
    }
}