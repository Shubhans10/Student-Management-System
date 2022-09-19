using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class DisplayAllEnrollments
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}