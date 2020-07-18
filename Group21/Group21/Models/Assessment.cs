using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Group21.Models
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentID { get; set; }

        [Required(ErrorMessage = "Enter Test Name")]
        [Display(Name = "Test Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Test Time")]
        [Display(Name = "Test Time")]
        public DateTime AssessmentTime { get; set; }

        [Required(ErrorMessage = "Enter Test Date")]
        [Display(Name = "Test Date")]
        public DateTime AssessmentDate { get; set; }

        [Required(ErrorMessage = "Enter Test Type")]
        [Display(Name = "Test Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter Test Venue")]
        [Display(Name = "Test Venue")]
        public string AssessmentVenue{ get; set; }

        [Required(ErrorMessage = "Enter Grade")]
        [Display(Name = "Grade")]
        public string Grade { get; set; }

        public string StID { get; set; }
         public virtual Student Student { get; set; }
        // public string Mark { get; set; }
        // public virtual Report Report { get; set; }
         public string subID { get; set; }
         public virtual sub subs { get; set; } 
    }
}