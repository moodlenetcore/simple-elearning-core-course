using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_elearning
{ 
    public class Course
    {
        public Guid CourseId { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public bool Active {get;set;}

        public DateTime CreatedOn {get;set;}
        public DateTime UpdatedOn {get;set;}
        public string CreatedBy {get;set;}
        public string UpdatedBy {get;set;}
    }
}