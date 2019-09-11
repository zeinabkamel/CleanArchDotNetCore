using CleanWebApp.Domains.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Domains.IRepositores
{
  public  interface ICourseRepositroy
    {
        IEnumerable<Course> GetCourses();
    }
}
