using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetTreat.Models;
using System.Threading.Tasks;
using SweetTreat.ViewModels;

namespace SweetTreat.Controllers
{
  public class AccountsController : Controllers
  {
    private readonly SweetTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;


    public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetTreatContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}