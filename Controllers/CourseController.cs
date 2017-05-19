using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace simple_elearning.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private ICourseService _courseService {get;set;}
        public CoursesController(ICourseService courseService){
            _courseService = courseService;
        }
        // GET api/courses
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courseService.Get();
        }

        // GET api/courses/5
        [HttpGet("{id}")]
        public Course Get(Guid id)
        {
            return _courseService.GetByID(id);
        }

        // POST api/courses
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/courses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/courses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
