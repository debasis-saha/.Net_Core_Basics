using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crud_Operation_Logging.Models;
using Microsoft.Extensions.Logging;

namespace Crud_Operation_Logging.Pages.EmployeeInfo
{
    public class CreateModel : PageModel
    {
        private readonly Crud_Operation_Logging.Models.EmployeeDataContext _context;

        private ILogger<CreateModel> _logs { get; set; }

        public CreateModel(Crud_Operation_Logging.Models.EmployeeDataContext context, ILogger<CreateModel> logs)
        {
            _context = context;
            this._logs = logs;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        [TempData]
        public string message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();
            var msg= $"Employee {Employee.EmployeeName} Added !!";
            message = msg;
            this._logs.LogCritical(msg);
            return RedirectToPage("./Index");
        }
    }
}