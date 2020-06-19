using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crud_Operation_Logging.Models;

namespace Crud_Operation_Logging.Pages.ProductInfo
{
    public class CreateModel : PageModel
    {
        private readonly Crud_Operation_Logging.Models.ProductDataContext _context;

        public CreateModel(Crud_Operation_Logging.Models.ProductDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Product.CreatedOn = DateTime.Now;

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}