using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Email-Address")]
        [Required(ErrorMessage ="Email address is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
    }
}