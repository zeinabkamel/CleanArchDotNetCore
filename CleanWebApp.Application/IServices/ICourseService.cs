using CleanWebApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Application.Interfaces
{
  public  interface ICourseService
    {
           CourseViewModel  GetCourses();
    }
}
