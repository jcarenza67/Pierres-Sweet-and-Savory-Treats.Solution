using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetTreat.Models;
using System.Threading.Tasks;
using SweetTreat.ViewModels;

namespace SweetTreat.Controllers
{
  public class AccountsController : Controller
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

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
      if(ModelState.IsValid)
      {
        ApplicationUser user = new ApplicationUser { UserName = model.Email };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if(result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          foreach(IdentityError error in result.Errors)
          {
            ModelState.AddModelError("", error.Description);
          }
          return View(model);
        }
      }
      return View(model);
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      else
      {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          ModelState.AddModelError(string.Empty, "Invalid login attempt.");
          return View(model);
        }
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}