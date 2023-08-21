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

    }
}
