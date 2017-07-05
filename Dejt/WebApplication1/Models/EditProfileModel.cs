using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EditProfile
    {
        [Display(Name = "Firstname:")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Lastname:")]
        [Required]
        public string LastName { get; set; }
        

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "About")]
        [Required]
        public string About { get; set; }
        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        
    }
}