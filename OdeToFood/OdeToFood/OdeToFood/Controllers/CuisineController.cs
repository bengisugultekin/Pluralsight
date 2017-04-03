using System;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name)
        {
            throw new Exception("hey");

            var message = Server.HtmlEncode(name);

            return RedirectToAction("Index", "Home", new { name = name });
        }
    }
}