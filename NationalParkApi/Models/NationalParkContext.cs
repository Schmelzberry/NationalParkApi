using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : DbContext
  {
    public DbSet<NationalPark> NationalParks { get; set; }

    public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<NationalPark>()
        .HasData(
          new NationalPark {NationalParkId= 1, Name="Voyageurs National Park", StateCode="MN", YearCreated=1975 }

        );
    }
  }
}