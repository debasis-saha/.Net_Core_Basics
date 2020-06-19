using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_Operation_Logging.Models;

namespace Crud_Operation_Logging.Pages.ProductInfo
{
    public class IndexModel : PageModel
    {
        private readonly Crud_Operation_Logging.Models.ProductDataContext _context;

        public IndexModel(Crud_Operation_Logging.Models.ProductDataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
