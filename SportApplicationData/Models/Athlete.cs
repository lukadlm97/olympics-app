using System.ComponentModel.DataAnnotations;

namespace SportApplicationData.Models
{
    public class Athlete
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name:")]
        [StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        [StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        [Required]
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public Sport Sport { get; set; }
        public Country Country { get; set; }
    }
}