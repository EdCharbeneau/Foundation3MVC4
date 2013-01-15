using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foundation3MVC4.Controllers
{
  public class FoundationController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "Welcome to ASP.NET MVC with Foundation 3.0.9!";

      return View();
    }
  }
}
