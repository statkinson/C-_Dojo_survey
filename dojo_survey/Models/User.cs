using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey.Models
{
    public class User
    {
        [Key]
        public int UerID { get; set; }

        [Required]
        [MinLength(2)]
        public string nameField { get; set; }

        [Required]
        public string selectLocation { get; set; }

        [Required]
        public string favorLanguage { get; set; }

        [Required]
        [MinLength(20)]
        public string commentField { get; set; }
    }
}