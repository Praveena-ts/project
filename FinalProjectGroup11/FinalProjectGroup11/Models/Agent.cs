using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class Agent
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email Address")]
        public string EmailId { get; set; }
        public decimal Rating { get; set; }
        [DisplayName("Agent Description")]
        public string AgentDescription { get; set; }
        [DisplayName("License Number")]
        public string LicenseNumber { get; set; }
        public List<Dwelling> Dwellings { get; set; }
        public SalesOffice SalesOffice { get; set; }
        public int SalesOfficeId { get; set; }
    }
}
