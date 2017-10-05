using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingApplication.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        public ActionResult Search(string name = "french")

        {
            throw new Exception("something terrible has happened!");

            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectToAction("Index", "Home", new { name = name });
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return Json(new {Message = message, Name = "Mahesh"}, JsonRequestBehavior.AllowGet);
        }
        
    }
}