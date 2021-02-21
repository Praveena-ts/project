using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup11.Models;

namespace FinalProjectGroup11.Data
{
    public class FinalProjectGroup11Context : DbContext
    {
        public FinalProjectGroup11Context (DbContextOptions<FinalProjectGroup11Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectGroup11.Models.Dwelling> Dwelling { get; set; }

        public DbSet<FinalProjectGroup11.Models.Agent> Agent { get; set; }

        public DbSet<FinalProjectGroup11.Models.City> City { get; set; }

        public DbSet<FinalProjectGroup11.Models.SalesOffice> SalesOffice { get; set; }

        public DbSet<FinalProjectGroup11.Models.Buyer> Buyer { get; set; }
    }
}
