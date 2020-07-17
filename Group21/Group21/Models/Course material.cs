using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Group21.Models
{
    public class Course_material
    {

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Enter course id")]
        [Display(Name = "Id Number: ")]
        public string courseID { get; set; }



        [Required(ErrorMessage = "Enter course title")]
        [Display(Name = "title: ")]
        public string title { get; set; }


        [Required(ErrorMessage = "Enter student id")]
        [Display(Name = "Id Number: ")]
        public virtual Student StID { get; set; }

        [Required(ErrorMessage = "Enter subject id")]
        [Display(Name = "subject id: ")]
        public virtual sub SubID { get; set; }

        [Required(ErrorMessage = "Enter staff id")]
        [Display(Name = "Id Number: ")]
        public virtual Staff StaffID { get; set; }


    }
}
}
}