using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Models
{
    [Table("Course2")]
    public class Course2
    {
        [Key]
        public int idCourse { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public decimal? price { get; set; }
        public string professor { get; set; }
        public string prof_image { get; set; }
    }
}
