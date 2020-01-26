using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportApplicationData.Models
{
    public enum Continent
    {
        EUR,ASU,SA,NA,AUS,AFR
    }
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Country Name:")]
        [StringLength(30, ErrorMessage = "Limit country name to 30 characters.")]
        [Required]
        public string Name { get; set; }
        public Continent Continent { get; set; }
    }
}
