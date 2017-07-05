using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LogInModel
    {
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Wrong email")]
        public string Email { get; set; }

        [Display(Name ="Password:")]
        [Required(ErrorMessage = "Wrong password")]
        public string Password { get; set; }

    }
}