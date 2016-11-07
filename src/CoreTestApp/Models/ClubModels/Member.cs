using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApp.Models.ClubModels
{
    public class Member
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Surame")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County")]
        public string County { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "CountyOfBirth")]
        public string CountyOfBirth { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
    }
}
