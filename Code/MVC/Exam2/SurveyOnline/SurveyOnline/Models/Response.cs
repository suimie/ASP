using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyOnline.Models
{
    public class Response
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name ="Full Name")]
        public String ResponderName { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        [Display(Name ="Phone Number")]
        public String Phone { get; set; }

        public Survey Survey { get; set; }
        public int SurveyId { get; set; }

        [Required]
        public String SurveyAnswer { get; set; }
    }
}