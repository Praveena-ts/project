using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class Buyer
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(30)]
        public string FirstName { get; set; }
        
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(30)]
        public string LastName { get; set; }
        
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is Required")]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
       
        
        
        public decimal Budget { get; set; }
        public List<Dwelling> Dwellings { get; set; }
    }
}
