﻿using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]

        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        
        public string Location { get; set; }
        public bool Active { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}