using Microsoft.EntityFrameworkCore;
using CaravanMVC.Models;

namespace CaravanMVC.DataAccess
{
    public class CaravanMvcContext : DbContext
    {

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Wagon> Wagons { get; set; }

        public CaravanMvcContext(DbContextOptions<CaravanMvcContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wagon>().HasData(
                new Wagon { Id = 1, Name = "Old Faithful", NumWheels = 4, Covered = true},
                new Wagon { Id = 2, Name = "Pain-Train", NumWheels = 3, Covered = false}
            );

            modelBuilder.Entity<Passenger>().HasData(
                new Passenger { Id = 1, Name = "John", Age = 20, Destination = "Utah"},
                new Passenger { Id = 2, Name = "Jesse", Age = 25, Destination = "Wisconsin" },
                new Passenger { Id = 3, Name = "Sarah", Age = 20, Destination = "California" }
            );
        }

    }
}
