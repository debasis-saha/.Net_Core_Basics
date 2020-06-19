using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleCoreEFPrjects.Models;

namespace SampleCoreEFPrjects.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly SampleCoreEFPrjects.Models.DataContext _context;

        public DetailsModel(SampleCoreEFPrjects.Models.DataContext context)
        {
            _context = context;
        }

        public Products Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
