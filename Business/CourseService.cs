using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace simple_elearning
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository {get;set;}

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
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
            return _courseRepository.Get();
        }

        public Course GetByID(Guid id)
        {
            return _courseRepository.GetByID(id);
        }

        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}