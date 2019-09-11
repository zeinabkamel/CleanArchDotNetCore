using CleanWebApp.Domains;
using CleanWebApp.Domains.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWebApp.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //  here  when you want to  seed  data
            modelBuilder.Entity<Course>().HasData(new { CourseID = 1, Title ="test 1", Credits = 1, Img = "Test1" });
        }
        public DbSet<Course> Courses { set; get; }
     }
}

