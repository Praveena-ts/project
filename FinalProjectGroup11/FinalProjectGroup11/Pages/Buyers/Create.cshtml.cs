using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProjectGroup11.Data;
using FinalProjectGroup11.Models;

namespace FinalProjectGroup11.Pages.Buyers
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
            return Page();
        }

        [BindProperty]
        public Buyer Buyer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Perform validation for Phone Number#
            int PhoneNumber = _context.Buyer.Count(x => x.PhoneNumber == Buyer.PhoneNumber);
            if (PhoneNumber > 0)
            {
                ModelState.AddModelError("Buyer.PhoneNumber", "This Phone Number already exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Buyer.Add(Buyer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
