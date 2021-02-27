using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(10)]
        public string State { get; set; }
        [DisplayName("County Name")]
        [StringLength(10)]
        public string CountyName { get; set; }
        public List<Dwelling> Dwellings { get; set; }
    }
}
