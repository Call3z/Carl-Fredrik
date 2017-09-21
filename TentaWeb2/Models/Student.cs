using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TentaWeb2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string GitHubHomeUrl { get; set; }
        public string GoogleAccount { get; set; }
    }
}
