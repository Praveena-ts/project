﻿using System;
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
        [Range(1, 10)]
        public int NumberBed { get; set; }

        [DisplayName("Number of Baths")]
        [Range(1, 10)]
        public int NumberBath { get; set; }

        [DisplayName("Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [DisplayName("Number of Floors")]
        [Range(1, 10)]
        public int NumberFloor { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        public Agent Agent { get; set; }
        [DisplayName("Agent")]
        public int AgentId { get; set; }
        public City City { get; set; }
        [DisplayName("City")]
        public int CityId { get; set; }
        public Buyer Buyer { get; set; }
        [DisplayName("Buyer")]
        public int? BuyerId { get; set; }
        [DisplayName("Days Listed")]
        public int DaysListed
        {
            get
            {
                DateTime today = DateTime.Today;
                
                DateTime ListedDate = DateAdded;
                double DaysSince = (today - DateAdded).TotalDays;
                int res = (int)Math.Ceiling(DaysSince);
                return res;
            }
        }

    }
}
