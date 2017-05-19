using System;
using System.Collections.Generic;

namespace simple_elearning
{
    public interface ICourseService
    {
        IEnumerable<Course> Get();
        Course GetByID(Guid id);

        void Update(Guid id);

        void Delete(Guid id);

        Course Add(Course course);

    }
}