using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//required namespace
using System.Linq;
using System.Web;

namespace ServerSideValidation.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +  
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +  
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",  
                            ErrorMessage = "Email is not valid")] 
        public string Email { get; set; }
    }
}