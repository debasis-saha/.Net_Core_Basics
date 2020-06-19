using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation_Logging.Models
{
    public class ProductDataContext : DbContext
    {
        public ProductDataContext (DbContextOptions<ProductDataContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_Operation_Logging.Models.Product> Product { get; set; }
    }
}
