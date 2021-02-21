using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroup11.Models
{
    public class Dwelling
    {
        public int Id { get; set; }

        [DisplayName("Dwelling Price")]
        public decimal DwellingPrice { get; set; }

        [DisplayName("Dwelling Address")]
        public string DwellingAddress { get; set; }

        [DisplayName("Total Area (SqFeet)")]
        public int TotalArea { get; set; }

        [DisplayName("Number of Beds")]
        public int NumberBed { get; set; }

        [DisplayName("Number of Baths")]
        public int NumberBath { get; set; }

        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

        [DisplayName("Number of Floors")]
        public int NumberFloor { get; set; }
        public string Description { get; set; }
        public Agent Agent { get; set; }
        public int AgentId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Buyer Buyer { get; set; }
        public int? BuyerId { get; set; }
    }
}
