using DataContextLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextLayer.DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=Deb; initial catalog=TrainingDemo;persist security info=True;user id=sa;password=abc123;");
        }       

        public Designation GetDesignationInfo(int desigId)
        {
            return this.Designations.FromSql<Designation>("Exec [EfCore].usp_GetDesignation @p_DesigId", new SqlParameter("p_DesigId", desigId)).FirstOrDefault();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department","EFCore").HasKey(p => p.DepartmentId);
            modelBuilder.Entity<Department>().Property(p => p.DepartmentCode).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Department>().Property(p => p.DepartmentName).IsRequired().HasMaxLength(20);
        }        
    }
}
