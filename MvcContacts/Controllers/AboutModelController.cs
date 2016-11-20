using MvcContacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcContacts.Controllers
{
    public class AboutModelController : Controller
    {
        // GET: AboutModel
        public ActionResult Index()
        {
            //Object controller = RouteData.Values["controller"];
            AboutModel model = new AboutModel();
            //model.Id = 1;
            //model.Name = "Matthias";
            //model.Ort = "Bremen";
            //ViewBag.Message = "Dies ist eine Message";
            //model.aboutModels();
            return View(aboutModels);
        }

        public List<AboutModel> aboutModels = new List<AboutModel>
        {
            new AboutModel { Id=1,Name="Matthias",Strasse="Axstedter Strasse",Ort="Bremen" },
            new AboutModel { Id=2,Name="Tomcat",Strasse="Finca",Ort="Mallorca" },
            new AboutModel { Id=3,Name="Johannes",Strasse="Axstedter Strasse 9",Ort="Bremen" }
        };

    }
}