using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportApplicationData.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Category Name:")]
        [Required]
        [StringLength(30, ErrorMessage = "Limit category name to 30 characters.")]
        public string CategoryName { get; set; }
        public IEnumerable<Sport> Sports { get; set; }
    }
}