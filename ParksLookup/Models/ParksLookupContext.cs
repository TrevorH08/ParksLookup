using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
      : base(options)
      {
      }

      public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Yellowstone", StateOrNational = "National", PointsOfInterest = "Steam Boat Geyser, Old Faithful Geyser Mammoth Hotsprings"},
          new Park { ParkId = 2, Name = "Yosemite", StateOrNational = "National", PointsOfInterest = "Half Dome, Glacier Point, Yosemite Falls"},
          new Park { ParkId = 3, Name = "Hearst San Simeon", StateOrNational = "State", PointsOfInterest = "Hearst Castle, San Simeon Pier, San Simeon Camp Grounds"}
        );
    }
  }
}