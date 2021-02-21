using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProjectGroup11.Data;
using FinalProjectGroup11.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FinalProjectGroup11.Pages.Dwellings
{
    public class CreateModel : PageModel
    {
        private readonly FinalProjectGroup11.Data.FinalProjectGroup11Context _context;

        public CreateModel(FinalProjectGroup11.Data.FinalProjectGroup11Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AgentId"] = new SelectList(_context.Set<Agent>(), "Id", "FirstName");
        ViewData["BuyerId"] = new SelectList(_context.Set<Buyer>(), "Id", "FirstName");
        ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Dwelling Dwelling { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var currentDate = DateTime.Today;
            var dateAdded = Dwelling.DateAdded.Date;

            if(dateAdded > currentDate)
            {
                ModelState.AddModelError("Dwelling.DateAdded", "Date Added can't be a future date");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Dwelling.Add(Dwelling);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
