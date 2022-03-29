using System;
using System.ComponentModel.DataAnnotations;

namespace mysqltest.Models.CovidCases
{
    public class Covid
    {
        [Required]
        public string Fname;
        
        [Required]
        public string Lname;
        
        [Required]
        public int studentId;

        [Required]
        public DateTime covidRecognised;
    }
}
