using CleanWebApp.Domains;
using CleanWebApp.Domains.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Application.ViewModels
{
   public class CourseViewModel
    {
        public IEnumerable<Course> Courses { set;get; }
    }
}
