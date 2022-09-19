using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set;}
        public string ContactNo { get; set; }
        public DateTime CreateDate { get; set; }
        public string Password { get; set; }
        public int CollegeId { get; set; }
        public College College { get; set; }
    }
}
