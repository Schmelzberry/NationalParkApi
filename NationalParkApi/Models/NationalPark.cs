using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace NationalParkApi.Models
{
  public class NationalPark 
  {
    public int NationalParkId { get; set; }
    
    [Required]
    [StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(2, MinimumLength = 0 )]
    public string StateCode { get; set; }
    [Required]
    public int YearCreated { get; set;}
  }
}