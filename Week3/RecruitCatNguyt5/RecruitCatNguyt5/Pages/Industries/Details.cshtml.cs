﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatNguyt5.Data;
using RecruitCatNguyt5.Models;

namespace RecruitCatNguyt5.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatNguyt5.Data.RecruitCatNguyt5Context _context;

        public DetailsModel(RecruitCatNguyt5.Data.RecruitCatNguyt5Context context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);
            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
