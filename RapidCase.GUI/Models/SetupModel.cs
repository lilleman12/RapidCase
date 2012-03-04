using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RapidCase.GUI.Models
{
    public class SetupModel
    {
        [Required(ErrorMessage = "Location field is required")]
        [Display(Name = "Location")]
        public string DBLocation { get; set; }

        [Required(ErrorMessage = "Port field is required")]
        [Display(Name = "Port")]
        [Range(0, 65500)]
        [StringLength(5)]        
        public string DBPort { get; set; }

        [Required(ErrorMessage="Password field is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string AdministratorPassword { get; set; }

        [Required(ErrorMessage = "Confirm password field is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("AdministratorPassword", ErrorMessage = "The password and confirmation password do not match.")]        
        public string ConfirmAdministratorPassword { get; set; }

    }
}