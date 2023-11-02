using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace NationalParkApi.Models
{
  public class StatePark 
  {
    public int StateParkId { get; set; }
    
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(2, MinimumLength = 0 )]
    public string StateCode { get; set; }
    
    [Required]
    public int YearCreated { get; set;}
  }
}