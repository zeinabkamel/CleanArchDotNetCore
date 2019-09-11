using CleanWebApp.Application.Interfaces;
using CleanWebApp.Application.ViewModels;
using CleanWebApp.Domains.IRepositores;
 
using CleanWebApp.Infra.Data.Repositroies;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepositroy _courseRepository;
        public CourseService(ICourseRepositroy courseRepositroy)
        {
            this._courseRepository = courseRepositroy;
        }
        public  CourseViewModel  GetCourses()
        {


             return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
