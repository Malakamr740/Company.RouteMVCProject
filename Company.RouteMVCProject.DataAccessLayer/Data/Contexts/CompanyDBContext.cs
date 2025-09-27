using Company.RouteMVCProject.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Company.RouteMVCProject.DataAccessLayer.Data.Contexts
{
    public class CompanyDBContext : DbContext
    {
        
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Server = . ; Database = CompanyRoute ; Trusted_Connection = true ; TrustServerCertificate = True");

        //}
        public DbSet<Department> departments { get; set; }
    }
}
 