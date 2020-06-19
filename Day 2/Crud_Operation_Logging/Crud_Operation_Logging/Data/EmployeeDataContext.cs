using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation_Logging.Models
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext (DbContextOptions<EmployeeDataContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_Operation_Logging.Models.Employee> Employee { get; set; }
    }
}
