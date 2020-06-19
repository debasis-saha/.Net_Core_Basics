using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_Operation_Logging.Models;

namespace Crud_Operation_Logging.Pages.EmployeeInfo
{
    public class IndexModel : PageModel
    {
        private readonly Crud_Operation_Logging.Models.EmployeeDataContext _context;

        public IndexModel(Crud_Operation_Logging.Models.EmployeeDataContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        [TempData]
        public string message { get; set; }

        public async Task OnGetAsync()
        {
            //Employee = await _context.Employee.ToListAsync();
            Employee = await this.GetEmployeeList();         
        }

        private Task<IList<Employee>> GetEmployeeList()
        {
            return Task.Run<IList<Employee>>(() =>
            {
                return _context.Employee
                    .FromSql("usp_GetAllEmployees").ToList();
            });
        }
    }
}
