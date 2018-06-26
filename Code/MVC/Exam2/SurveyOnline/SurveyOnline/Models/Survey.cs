using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyOnline.Models
{
    public class Survey
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public String Title { get; set; }

        [Required]
        public String SurveyQuestion { get; set; }

        [Required]
        public byte TopicId { get; set; }
        public Topic Topic { get; set; }
        

        [MaxLength(255)]
        public String Author  { get; set; }

        public DateTime? DeadlineDate { get; set; }
    }
}