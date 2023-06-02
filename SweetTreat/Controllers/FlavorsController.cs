using SweetTreat.Models;
using Microsoft.AspNetCore.Mvc;

namespace SweetTreat.Controllers
{
  public class ClassNmeController : Controller
  {
    [HttpGet("/")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}