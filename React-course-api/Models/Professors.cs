using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Models
{
    [Table("Professors")]
    public class Professors
    {
        [Key]
        public int idProfessor { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorSurName { get; set; }
        public int idImageRepository { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
