using CleanWebApp.Domains.IRepositores;
using CleanWebApp.Domains.Model;
using CleanWebApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Infra.Data.Repositroies
{
    public class CourseRepository : ICourseRepositroy
    {
        private UniversityDBContext universityDbContext;
        public  CourseRepository( UniversityDBContext context)
        {
            this.universityDbContext = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return universityDbContext.Courses;
        }
    }
}
