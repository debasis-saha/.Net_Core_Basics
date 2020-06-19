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
    public class IndexModel : PageModel
    {
        private readonly SampleCoreEFPrjects.Models.DataContext _context;

        public IndexModel(SampleCoreEFPrjects.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Products> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
