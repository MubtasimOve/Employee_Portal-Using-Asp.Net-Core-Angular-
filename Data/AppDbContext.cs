using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet <Employee> Employees { get; set; }

        internal async Task SaveChangesAysnc()
        {
            throw new NotImplementedException();
        }
    }
}
