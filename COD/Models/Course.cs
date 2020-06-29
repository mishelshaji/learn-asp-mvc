using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COD.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage="Please provide the course name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide the author name")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please provide the price")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "Please provide the course duration")]
        public int Duration { get; set; }
        public string About { get; set; }
    }
}