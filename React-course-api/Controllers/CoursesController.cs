using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using React_course_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;
        private readonly ReactCourseDbContext _dbContext;

        public CoursesController(ILogger<CoursesController> logger, ReactCourseDbContext dbContext)
        {
            this._logger = logger;
            this._dbContext = dbContext;
        }

        [Route("[controller]/AllCourses")]
        [HttpGet]
        public IEnumerable<Courses> GetCourses()
        {
            var lstCourses = _dbContext.Courses.Where(x => x.Enabled == true).ToList();

            return lstCourses;
        }
    }
}
