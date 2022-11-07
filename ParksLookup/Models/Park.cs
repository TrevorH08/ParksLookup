using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "Name must be less that 25 characters, try cutting it down if it's too long")]
    public string Name { get; set; }
    [Required]
    public string StateOrNational { get; set; }
    public string PointsOfInterest { get; set; }
  }
}