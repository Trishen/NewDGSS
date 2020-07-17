using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Group21.Models
{
    public class Student
    {

        [Key]
        [Required(ErrorMessage = "Enter your id number")]
        [Display(Name = "Id")]
        public string StID { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Enter your surname")]
        [Display(Name = "Surname")]
        public string StudentSurname { get; set; }

        [Required(ErrorMessage = "Select your gender")]
        [Display(Name = "Gender")]
        public string StudentGender { get; set; }

        [Required(ErrorMessage = "Enter your address")]
        [Display(Name = "Address")]
        public string StudentAddress { get; set; }

        [Required(ErrorMessage = "Enter your town")]
        [Display(Name = "Town")]
        public string StudentTown { get; set; }

        [Required(ErrorMessage = "Select your grade")]
        [Display(Name = "Grade")]
        public string StudentGrade { get; set; }

        [Required(ErrorMessage = "Enter course")]
        [Display(Name = "Course")]
        public string StudentCourse { get; set; }

        [Required(ErrorMessage = "Enter contact number")]
        [Display(Name = "Contact number")]
        public string StudentContact { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Password")]
        public string StudentPassword { get; set; }

        [Required(ErrorMessage = "Enter parentguardian name")]
        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }

        [Required(ErrorMessage = "Enter parent id")]
        [Display(Name = "Parent Id")]
        public string ParentId { get; set; }

        [Required(ErrorMessage = "Enter parent contact number")]
        [Display(Name = "Parent Contact")]
        public string ParentContact { get; set; }

        [Required(ErrorMessage = "Upload your birth certificate")]
        [Display(Name = "Birth Certificate")]
        public string StudentBirthCertURL { get; set; }

        [Required(ErrorMessage = " Upload your last official school report")]
        [Display(Name = "Report card")]
        public string StudentReportURL { get; set; }

        [Required(ErrorMessage = " Upload proof of residence")]
        [Display(Name = "Proof of residence")]
        public string StudentProofResURL { get; set; }


        [Display(Name = "Study permit")]
        public string StudentPermitURL { get; set; }


        [Display(Name = "Allow registration")]
        public bool StudentAllowReg { get; set; }


    }
}