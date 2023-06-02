using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SweetTreat.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
  }
}