using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class AddStudent
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int StudentId { get; set;}

        public int ContactNo { get; set; }

        [Required]
        public int CollegeId { get; set; }

        public DateTime date { get; set; }
    }
}