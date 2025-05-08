using CovadisLeaseCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CovadisLeaseCar.Domain.Data
{
    public class LeaseCarContext(DbContextOptions<LeaseCarContext> options) : DbContext(options)
    {
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaseCar> LeaseCars { get; set; }
    }
}

   
