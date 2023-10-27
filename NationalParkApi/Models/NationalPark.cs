using System.Linq;

namespace NationalParkApi.Models
{
  public class NationalPark 
  {
    public int NationalParkId { get; set; }
    public string Name { get; set; }
    public string StateCode { get; set; }
    public int YearCreated { get; set;}
  }
}