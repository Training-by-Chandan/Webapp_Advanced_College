using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class UserLoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "Password must be of atleast 6 characters.")]
        public string PasswordHash { get; set; }
    }

    public class UserRegistrationViewModel
    {
        [Required]
        [Display(Name ="Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        [MinLength(6,ErrorMessage ="Password must be of atleast 6 characters.")]
        public string PasswordHash { get; set; }
        [Required]
        [Display(Name ="Confirm Password")]
        [Compare("PasswordHash", ErrorMessage ="Password not matched")]
        public string ConfirmPasswordHash { get; set; }
        [Required]
        [Display(Name ="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }


        public Users User
        {
            get
            {
                var tmp = new Users() {  Email=this.Email, PasswordHash=this.PasswordHash, PhoneNumber=this.PhoneNumber, UserName=this.UserName};
                return tmp;
            }
        }
    }
}