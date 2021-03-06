﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProjectGroup11.Data;
using FinalProjectGroup11.Models;

namespace FinalProjectGroup11.Pages.Agents
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
        ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Agent Agent { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "Id", "Name");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Perform validation for Duplicate License#
            int AgentCount = _context.Agent.Count(x => x.LicenseNumber == Agent.LicenseNumber);
            if(AgentCount > 0)
            {
                ModelState.AddModelError("Agent.LicenseNumber","Agent with this License Number already exists");
            }
            //Recheck Validation Status
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _context.Agent.Add(Agent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
