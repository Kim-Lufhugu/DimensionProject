using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace organisation_x_api.Entities
{
    public class OrganisationXContext : DbContext
    {
        public OrganisationXContext(DbContextOptions<OrganisationXContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
