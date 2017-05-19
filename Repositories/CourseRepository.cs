using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace simple_elearning
{
    public class CourseRepository : ICourseRepository
    {
        private SimpleELearningContext context;

        public CourseRepository(SimpleELearningContext context)
        {
            this.context = context;
        }
        public Course Add(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> Get()
        {
            return context.Courses.AsNoTracking().ToList();
        }

        public Course GetByID(Guid id)
        {
            return context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
        }

        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}