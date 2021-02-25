using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup11.Data;
using FinalProjectGroup11.Models;

namespace FinalProjectGroup11.Pages.Dwellings
{
    public class SearchModel : PageModel
    {
        private readonly FinalProjectGroup11.Data.FinalProjectGroup11Context _context;

        public SearchModel(FinalProjectGroup11.Data.FinalProjectGroup11Context context)
        {
            _context = context;
        }

        public IList<Dwelling> Dwelling { get;set; }

        public bool SearchCompleted { get; set; }
        public string Query { get; set; }
        public decimal MaxPrice { get; set; }

        public async Task OnGetAsync(string query, decimal maxPrice)
        {
            Query = query;
            MaxPrice = maxPrice;

            if(!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                if(MaxPrice > 0)
                {
                    Dwelling = await _context.Dwelling
                    .Where(x => (x.DwellingAddress.StartsWith(query) && x.DwellingPrice <= MaxPrice))
                    .ToListAsync();
                }
                else
                {
                    Dwelling = await _context.Dwelling
                    .Where(x => (x.DwellingAddress.StartsWith(query)))
                    .ToListAsync();
                }
                
            }
            else
            {
                SearchCompleted = false;
                Dwelling = new List<Dwelling>();
            }
        }
    }
}
