using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContacts.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcContacts.Models;
using System.Web.Routing;
using System.Web;
using System.Security.Principal;
using MvcContacts.Tests.Models;
using System.Web.Mvc;

namespace MvcContacts.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {   

       public Contacts GetContact()
       {
          return  GetContact(1,"Matthias", "Veenhuis");

       }

      public Contacts GetContact(int id, string firstName, string lastName)
      {   
            return new Contacts
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Phone = "710-555-0173",
                Email = "janet1@adventure-works.com"
            };
      }

        //public HomeController GetHomerController(IContactRepository repository)
        //{
        //    HomeController controller = new HomeController(repository);
        //    controller.ControllerContext = new System.Web.Mvc.ControllerContext
        //    {
        //        Controller = controller,
        //        RequestContext = new RequestContext(new MockHttpContext(), new RouteData())
        //    };
        //    return controller;

        //}

        //[TestMethod]
        //public void Index_Get_AsksForIndexView()
        //{   //Arrange
        //    var controller = GetHomerController(new InMemoryContactRepository());
        //    //Act
        //    ViewResult result = controller.Index();
        //    //Assert
        //    Assert.AreEqual("Index", result.ViewName);
        //}

        //[TestMethod]
        //public void Index_Get_RetrievesAllContactsFromRepository()
        //{
        //    Contacts contact1 = this.GetContact(1,"Orlando", "Gee");
        //    Contacts contact2 = this.GetContact(2,"Keith", "Harris");
        //    InMemoryContactRepository repository = new InMemoryContactRepository();
        //    repository.Add(contact1);
        //    repository.Add(contact2);
        //    HomeController controller = this.GetHomerController(repository);
        //    ViewResult result = controller.Index();
        //    var model = (IEnumerable<Contacts>)result.ViewData.Model;
        //    CollectionAssert.Contains(model.ToList(), contact1);

        //}
       
    }
    public class MockHttpContext : HttpContextBase
    {
        private readonly IPrincipal _user = new GenericPrincipal(new GenericIdentity("userName"),null);

        public IPrincipal User
        {  
            set { base.User = value; }
            get { return _user; }
        }
    }

}