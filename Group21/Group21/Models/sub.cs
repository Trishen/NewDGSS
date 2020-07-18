using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace Group21.Models
{
    public class sub
    {
    
        [Key]
        [Required(ErrorMessage = "Enter subject ID")]
        [Display(Name = "Id")]
        public int subID { get; set; }

        [Required(ErrorMessage = "Enter subject name")]
        [Display(Name = "Name")]
        public string subName { get; set; }

        [Required(ErrorMessage = "Enter subject requirements")]
        [Display(Name = "Requirements")]
        public string subRequirement { get; set; }


    }
}