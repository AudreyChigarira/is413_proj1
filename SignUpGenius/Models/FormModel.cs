using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class FormModel
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Please enter a valid phone number.")]
        public string? Phone { get; set; }
    }
}
