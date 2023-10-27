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
          new NationalPark {NationalParkId= 1, Name="Voyageurs National Park", StateCode="MN", YearCreated=1975 },
          new NationalPark {NationalParkId= 2, Name="Grand Portage National Monument", StateCode="MN", YearCreated=1778 },
          new NationalPark {NationalParkId= 3, Name="Crater Lake National Park", StateCode="OR", YearCreated=1902 },
          new NationalPark {NationalParkId= 4, Name="Mount Rainier National Park", StateCode="WA", YearCreated=1899 },
          new NationalPark {NationalParkId= 5, Name="North Cascades National Park", StateCode="WA", YearCreated=1968 },
          new NationalPark {NationalParkId= 6, Name="Olympic National Park", StateCode="WA", YearCreated=1938 },
          new NationalPark {NationalParkId= 7, Name="Death Valley National Park ", StateCode="CA", YearCreated=1994 },
          new NationalPark {NationalParkId= 8, Name="Channel Islands National Park", StateCode="CA", YearCreated=1980 },
          new NationalPark {NationalParkId= 9, Name="Joshua Tree National Park", StateCode="CA", YearCreated=1994 },
          new NationalPark {NationalParkId= 10, Name="Pinnacles National Park", StateCode="CA", YearCreated=2013 },
          new NationalPark {NationalParkId= 11, Name="Great Smoky Mountains National Park", StateCode="TN", YearCreated=1934 },
          new NationalPark {NationalParkId= 12, Name="Kenai Fjords National Park", StateCode="AK", YearCreated=1980 },
          new NationalPark {NationalParkId= 13, Name="Mesa Verde National Park", StateCode="CO", YearCreated=1906 },
          new NationalPark {NationalParkId= 14, Name="Rocky Mountain National Park ", StateCode="CO", YearCreated=1915 },
          new NationalPark {NationalParkId= 15, Name="Glacier National Park", StateCode="MT", YearCreated=1910 },
          new NationalPark {NationalParkId= 16, Name="Yellowstone National Park", StateCode="WY", YearCreated=1872 },
          new NationalPark {NationalParkId= 17, Name="Big Bend National Park", StateCode="TX", YearCreated=1944 },
          new NationalPark {NationalParkId= 18, Name="Guadalupe Mountains National Park ", StateCode="TX", YearCreated=1972 },
          new NationalPark {NationalParkId= 19, Name="Hawaii Volcanoes National Park", StateCode="HI", YearCreated=1916 },
          new NationalPark {NationalParkId= 20, Name="Denali National Park", StateCode="AK", YearCreated=1917 }

        );
    }
  }
}