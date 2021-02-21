using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        [DisplayName("County Name")]
        public string CountyName { get; set; }
        public List<Dwelling> Dwellings { get; set; }
    }
}
