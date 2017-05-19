using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System;

namespace simple_elearning.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SimpleELearningContext context = app.ApplicationServices.GetRequiredService<SimpleELearningContext>();
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(
                new Course
                {
                    FullName = "test1",
                    ShortName =  "aa",
                    Active = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(1)
                },
                new Course
                {
                    FullName = "test1",
                    ShortName =  "aa",
                    Active = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(1)
                },
                new Course
                {
                    FullName = "test1",
                    ShortName =  "aa",
                    Active = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(1)
                });
            };
            context.SaveChanges();
        }
    }
}
