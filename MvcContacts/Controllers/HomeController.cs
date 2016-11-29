using MvcContacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace MvcContacts.Controllers
{   
    [HandleError]
    public class HomeController : Controller
    {
        MvcContactsDB db = new MvcContactsDB();

        public ActionResult AutoComplete(string term)
        {
            var model = db.Restaurants.Where(x => x.Name.StartsWith(term))
                        .Take(10).Select(r => new { label = r.Name });
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index(string searchTerm, int page=1)
        {
            var model = db.Restaurants.OrderBy(x => x.Name).Where(x => searchTerm == null || x.Name.StartsWith(searchTerm) 
            || x.Name.Contains(searchTerm))
            .ToPagedList(page,10);
            if (Request.IsAjaxRequest())

            {
                return PartialView("Restaurants", model);
            }
            return View(model);
        }
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Message = "This is Tomcat with Marzipan";
            //ViewBag.Location = "Finca at Mallorca";
            AboutModel model = new AboutModel();
            model.Name = "Tomcat";
            model.Strasse = "Finca 3";
            model.Ort = "Mallorca";


            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //private IContactRepository _repository;
        //public HomeController() : this(new EntityContactManagerRepository())
        //{

        //}

        //public HomeController(IContactRepository IcontactRepository)
        //{
        //    this._repository = IcontactRepository;
        //}

        ////public ViewResult Index()
        ////{
        ////    throw new NotImplementedException();
        ////}

        //public ViewResult Index()
        //{
        //    return View("Index", _repository.GetContacts());
        //}

        protected override void Dispose(bool disposing)
        {
            if(db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}