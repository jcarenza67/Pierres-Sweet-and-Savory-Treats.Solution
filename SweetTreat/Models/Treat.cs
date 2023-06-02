using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetTreat.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Please enter a treat name.")]
    public string TreatName { get; set; }
    public List<FlavorTreat> JoinFlavorTreat { get; }
    public ApplicationUser User { get; set; }
  }
}