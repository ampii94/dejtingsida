using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class RegisterModel
    {
        [Display(Name = "First name:")]
        [Required(ErrorMessage = "Please enter a first name.")]
        public string Firstname { get; set; }
        [Display(Name = "Last name:")]
        [Required(ErrorMessage = "Please enter a last name.")]
        public string Lastname { get; set; }
        [Display(Name = "Email:")]
        [Required]
        [RegularExpression(@"(?=^.{3,20}$)^[a-zA-Z][a-zA-Z0-9]*[._-]?[a-zA-Z0-9]+$", ErrorMessage = "Your username must be between 3-20 characters.")]
        public string Email { get; set; }
        [Display(Name = "Password:")]
        [Required]
        [RegularExpression(@"(?=^.{3,20}$)^[a-zA-Z][a-zA-Z0-9]*[._-]?[a-zA-Z0-9]+$", ErrorMessage = "Your password must be between 3-20 characters.")]
        public string Password { get; set; }
        
        [Display(Name = "About")]
        [Required]
        [RegularExpression(@".{10,}", ErrorMessage = "Your description needs to be atleast 10 characters long.")]
        public string About { get; set; }
        [Display(Name = "Date of birth: (yyyy-mm-dd)")]
        [Required]
        public DateTime DateofBirth { get; set; }
        [Display(Name = "Gender:")]
        [Required]
        public string Gender { get; set; }
        
       
    }
}