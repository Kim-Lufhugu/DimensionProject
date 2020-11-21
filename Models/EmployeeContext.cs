using Microsoft.EntityFrameworkCore;

namespace DimensionProject.Models
{
    public class EmployeeContext
    {
        public EmployeeContext : DbContext {
            public EmployeeContext(DbContextOptions<EmployeeContext> options)
                : base(options) {}

            public DbSet<Employee> Employees { get; set; }
        }
    }
}