using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FinalProjectGroup11.Models
{
    public class Agent
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        [Required]
        [StringLength(12)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DisplayName("Email Address")]
        [EmailAddress]
        public string EmailId { get; set; }
        public decimal Rating { get; set; }
        [DisplayName("Agent Description")]
        [Required]
        [StringLength(200)]
        public string AgentDescription { get; set; }
        [DisplayName("License Number")]
        [Required]
        [StringLength(10)]
        public string LicenseNumber { get; set; }
        public List<Dwelling> Dwellings { get; set; }
        [DisplayName("Sales Office")]
        public SalesOffice SalesOffice { get; set; }
        [DisplayName("Sales Office")]
        public int SalesOfficeId { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
