﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models   
{
    public enum Grade
    { 
        A,B,C,D,E,F
    }
    public class Enrollment
    { 
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID {get;set;}
        [DisplayFormat(NullDisplayText ="No grace")]

        public Grade? Grade { get; set; }
           
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}