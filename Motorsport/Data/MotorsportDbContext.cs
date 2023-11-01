using Microsoft.EntityFrameworkCore;
using Motorsport.Model.Domain;

namespace Motorsport.Data
{
    public class MotorsportDbContext : DbContext
    {
        public MotorsportDbContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<Vehicle> _RaceIds { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>()
         .HasKey(e => e.Id);

            modelBuilder.Entity<Race>()
           .Property(d => d.ParticipantDriverIds)
           .HasConversion(
               v => string.Join(',', v),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList()
           );
        }
    }
    
}
