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
    public class ReactCoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;
        private readonly ReactCourseDbContext _dbContext;

        public ReactCoursesController(ILogger<CoursesController> logger, ReactCourseDbContext dbContext)
        {
            this._logger = logger;
            this._dbContext = dbContext;
        }

        [Route("[controller]/allCourses")]
        [HttpGet]
        public IEnumerable<Course2> GetAllCourses()
        {
            return _dbContext.ReactCourses.ToList();
        }

        [Route("[controller]/couseDeatil/{id}")]
        [HttpGet]
        public ActionResult GetCouserDetail(int id)
        {
            try
            {
                var course = _dbContext.ReactCourses.FirstOrDefault(x => x.idCourse == id);

                if (course == null)
                    return BadRequest();

                return Ok(course);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
