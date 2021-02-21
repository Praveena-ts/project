using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(100)]
        [Required(ErrorMessage = "Dwelling Address is Required")]
        public string DwellingAddress { get; set; }

        [DisplayName("Total Area (SqFeet)")]
        public int TotalArea { get; set; }

        [DisplayName("Number of Beds")]
        public int NumberBed { get; set; }

        [DisplayName("Number of Baths")]
        public int NumberBath { get; set; }

        [DisplayName("Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [DisplayName("Number of Floors")]
        public int NumberFloor { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        public Agent Agent { get; set; }
        public int AgentId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Buyer Buyer { get; set; }
        public int? BuyerId { get; set; }
    }
}
