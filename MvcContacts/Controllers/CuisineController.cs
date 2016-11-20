using MvcContacts.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcContacts.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        //[Log]
        public ActionResult Search(string name)
        {
            //throw new Exception("A Terrible mistake is hapen.");
            var message = Server.HtmlEncode(name="Matthias");
            //return Json(new { name = "Matthias" }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Index","Contacts",new { name=name });
            //return File("~/Content/Site.css", "text/css");
            return Content(message);
        }
    }
}