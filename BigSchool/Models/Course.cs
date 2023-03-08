using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lectuter { get; set; }
        [Required]
        public string LectuterId { get; set; }
        [Required]
        [StringLength(250)]
        public string Place { get; set; }
        public DateTime DateTiem { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

    }

}