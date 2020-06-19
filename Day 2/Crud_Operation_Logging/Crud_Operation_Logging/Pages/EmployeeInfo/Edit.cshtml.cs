using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_Operation_Logging.Models;
using System.Data.SqlClient;

namespace Crud_Operation_Logging.Pages.EmployeeInfo
{
    public class EditModel : PageModel
    {
        private readonly Crud_Operation_Logging.Models.EmployeeDataContext _context;

        public EditModel(Crud_Operation_Logging.Models.EmployeeDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);
            //Employee = await this.GetEmployeeInfo(id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(Employee.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }

        private Task<Employee> GetEmployeeInfo(int? id)
        {
            var employeeId = new SqlParameter() { ParameterName = "@p_EmployeeId", SqlDbType = System.Data.SqlDbType.Int, Value = id };
            return Task.Run<Employee>(() =>
            {
                return _context.Employee
                    .FromSql("usp_GetAllEmployees p_EmployeeId", employeeId).FirstOrDefault();
            });
        }
    }
}
