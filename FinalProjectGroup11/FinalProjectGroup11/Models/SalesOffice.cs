using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class SalesOffice
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(10)]
        public string Name { get; set; }
       
        public string Address { get; set; }
        [DisplayName("Manager Name")]
        public string ManagerName { get; set; }
        public List<Agent> Agents { get; set; }
    }
}
