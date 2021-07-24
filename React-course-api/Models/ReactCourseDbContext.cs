using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Models
{
    public class ReactCourseDbContext : DbContext
    {
        public ReactCourseDbContext(DbContextOptions<ReactCourseDbContext> options)
            : base(options) { }

        #region DataSet
        public DbSet<ImageRepository> Images { get; set; }
        public DbSet<Professors> Professors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Course2> ReactCourses { get; set; }
        #endregion
    }
}
