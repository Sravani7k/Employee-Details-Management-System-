//repository or database layer
using Microsoft.EntityFrameworkCore;
using MyApp.Model.Entity;


namespace MyApp.Data
{
    public class ApplicationDbContext : DbContext //ctor or ctrl+. =>to create constructor automatically
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
