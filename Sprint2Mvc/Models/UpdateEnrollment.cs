using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class UpdateEnrollment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

    }
}