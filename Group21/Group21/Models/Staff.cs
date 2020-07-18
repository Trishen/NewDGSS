using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Group21.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Choose your gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Choose date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Enter assigned Subject")]
        [Display(Name = "Assigned Subject: ")]
        public string subject { get; set; }

        [Required(ErrorMessage = "Select Assigned grade")]
        [Display(Name = "Assigned grade")]
        public string grade { get; set; }


        [Required(ErrorMessage = "Enter phone number")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter your email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter your position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Enter you salary")]
        public int Salary { get; set; }
    }
}
    
