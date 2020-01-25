using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportApplicationData.Models
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Sport Name:")]
        [Required]
        [StringLength(30, ErrorMessage = "Limit sport name to 30 characters.")]
        public string Name { get; set; }
        public bool Individual { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Athlete> Athletes { get; set; }
    }
}
