using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : DbContext
  {
    public DbSet<NationalPark> NationalParks { get; set; }

    public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options) : base(options)
    {
    }
  }
}