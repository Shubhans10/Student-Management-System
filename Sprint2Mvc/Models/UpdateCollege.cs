using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sprint2Mvc.Models
{
    public class UpdateCollege
    {
       
            [Required]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }
        
    }
}