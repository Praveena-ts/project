﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup11.Data;
using FinalProjectGroup11.Models;

namespace FinalProjectGroup11.Pages.Buyers
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectGroup11.Data.FinalProjectGroup11Context _context;

        public IndexModel(FinalProjectGroup11.Data.FinalProjectGroup11Context context)
        {
            _context = context;
        }

        public IList<Buyer> Buyer { get;set; }

        public async Task OnGetAsync()
        {
            Buyer = await _context.Buyer.ToListAsync();
        }
    }
}
