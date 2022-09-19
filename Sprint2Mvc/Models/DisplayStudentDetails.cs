using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class DisplayStudentDetails
    {
        
        public int StudentId { get; set; }

        
        public string StudentName { get; set;}

       
        public int ContactNo { get; set; }
      
        public int CollegeId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
