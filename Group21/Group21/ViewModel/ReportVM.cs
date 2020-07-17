using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group21.ViewModel
{
    public class ReportVM
    {

        [Key]
        public int ReportID { get; set; }

        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentCourse { get; set; }
        public int SubjectName { get; set; }
        public int Percentage { get; set; }
        public int MarksObtained { get; set; }
        public string FirstName { get; set; }
        public string Comment { get; set; }
    }
}