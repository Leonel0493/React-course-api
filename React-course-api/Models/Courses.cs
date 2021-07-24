using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Models
{
    [Table("Courses")]
    public class Courses
    {
        [Key]
        public int idCourse { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int idProfessor { get; set; }
        public int idImageRepository { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
