using ProjectName.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
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