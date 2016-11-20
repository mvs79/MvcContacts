using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContacts.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcContacts.Controllers.Tests
{
    [TestClass()]
    public class AboutModelControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            AboutModelController controller = new AboutModelController();          
            var viewResult = controller.Index() as ViewResult;
            Assert.AreEqual("Dies ist eine Message",viewResult.ViewBag.Message);
            //Assert.IsInstanceOfType(controller.Index(),typeof(System.Web.Mvc.ActionResult));
        }
    }
}