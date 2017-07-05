using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EditProfileModel
    {
        [Display(Name = "First name:")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name:")]
        [Required]
        public string LastName { get; set; }
        
        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }


        [Display(Name = "About")]
        [Required]
        [RegularExpression(@".{10,}", ErrorMessage = "Your description needs to be atleast 10 characters long.")]
        public string About { get; set; }

        [Display(Name = "Visible")]
        [Required]
        public bool Visible { get; set; }
        
        

    }
}