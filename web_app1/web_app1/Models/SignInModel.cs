using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_app1.Models
{
    public class SignInModel
    {
        [Required,EmailAddress]
        public string EMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember! Me")]
        public bool RememberMe{ get; set;}
    }
}
