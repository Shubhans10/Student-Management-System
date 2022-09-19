using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class UpdateCourse
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Duration {get; set; }

        public string Description { get; set; }
    }
}