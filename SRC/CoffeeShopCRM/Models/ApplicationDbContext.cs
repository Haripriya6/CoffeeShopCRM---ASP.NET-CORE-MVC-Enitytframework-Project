using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_CustomerInfo_Module.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        { }
        
        public DbSet<Customer> Customers { get; set; }

        //public DbSet<State> States { get; set; }

        //public DbSet<Country> Countries { get; set; }

        //public DbSet<City> Cities { get; set; }
    }
}
