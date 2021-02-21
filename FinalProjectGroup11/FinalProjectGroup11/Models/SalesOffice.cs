using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class SalesOffice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [DisplayName("Manager Name")]
        public string ManagerName { get; set; }
        public List<Agent> Agents { get; set; }
    }
}
