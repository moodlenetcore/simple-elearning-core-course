using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace simple_elearning
{ 
    public class CourseVM
    {
        public int CourseId { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public bool Active {get;set;}
    }
}