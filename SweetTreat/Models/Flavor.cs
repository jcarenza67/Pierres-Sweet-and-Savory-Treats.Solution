using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetTreat.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Please enter a flavor name.")]
    public string FlavorName { get; set; }
    public List<FlavorTreat> JoinFlavorTreat { get; }
    public ApplicationUser User { get; set; }
  }
}
