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
        public string AssessmentID { get; set; }

        [Required(ErrorMessage = "Enter Date")]
        [Display(Name = "Date")]

        public DateTime AssessmentDate { get; set; }
        [Required(ErrorMessage = "Enter Assessment Type")]
        [Display(Name = "Assessment Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter Exam")]
        [Display(Name = "Exam")]
        public string AssessmentExam { get; set; }

        /* public string StudentID { get; set; }
         public virtual Student Student { get; set; }
         public string Mark { get; set; }
         public virtual Report Report { get; set; }
         public string SubjectID { get; set; }
         public virtual Subject Subject { get; set; } */
    }
}