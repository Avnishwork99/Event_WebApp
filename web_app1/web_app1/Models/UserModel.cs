using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_app1.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please enter Your Name")]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your Email")]
        [Display(Name="Email Address")]
        [EmailAddress(ErrorMessage ="Enter a valid Email")]
        public string EMail { get; set; }
        [Required(ErrorMessage ="Please enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
