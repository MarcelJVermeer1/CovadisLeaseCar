using CovadisLeaseCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CovadisLeaseCar.Domain.Data
{
    public class LeaseCarContext(DbContextOptions<LeaseCarContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<LeaseCar> LeaseCars { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ride>()
                .HasOne(r => r.Employee)
                .WithMany(e => e.Rides)
                .HasForeignKey(r => r.IdEmployee);

            modelBuilder.Entity<Ride>()
                .HasOne(r => r.LeaseCar)
                .WithMany(lc => lc.Rides)
                .HasForeignKey(r => r.IdLeaseCar);
        }
    }
}

   
