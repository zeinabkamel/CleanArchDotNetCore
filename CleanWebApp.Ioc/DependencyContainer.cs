using CleanWebApp.Application.Interfaces;
using CleanWebApp.Application.Services;
using CleanWebApp.Domains.IRepositores;
using CleanWebApp.Infra.Data.Repositroies;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanWebApp.Infra.Ioc
{
    public class DependencyContainer
    {
        public static  void RegisterServices(IServiceCollection serviceCollection)
        {
            //  Application Layer
            serviceCollection.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer

            serviceCollection.AddScoped<ICourseRepositroy, CourseRepository>();


        }
    }
}
