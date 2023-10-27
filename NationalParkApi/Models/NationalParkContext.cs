using Microsoft.Entity.FrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : dbContextOptions
  {
    public DbSet <NationalPark> NationalParks { get; set; }

    public NationalParkApiContext(dbContextOptions<NationalParkApiContext> options) : base(options)
    {
    }
  }
}