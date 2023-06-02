using System.ComponentModel.DataAnnotations;

namespace SweetTreat.ViewModels
{
  public class LoginViewModel
  {
    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Please enter your password.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}