using MvcContacts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcContacts.Controllers
{   
    [HandleError]
    public class HomeController : Controller
    {
        MvcContactsDB db = new MvcContactsDB();
        public ActionResult Index()
        {
            //return View(db.Restaurants.ToList());
            var query = from restaurant in db.Restaurants
                        select new RestaurantViewModel
                        {
                            Id = restaurant.Id,
                            Name = restaurant.Name,
                            Street = restaurant.Street,
                            Place = restaurant.Place,
                            Reviews = restaurant.Reviews
                        };

            return View(query);

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