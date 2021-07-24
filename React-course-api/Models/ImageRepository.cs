using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace React_course_api.Models
{
    [Table("ImageRepository")]
    public class ImageRepository
    {
        [Key]
        public int idImage { get; set; }
        public byte[] ImageFile { get; set; }
        public string Description { get; set; }
        public int idImageFor { get; set; }
        public int idTypeImage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
