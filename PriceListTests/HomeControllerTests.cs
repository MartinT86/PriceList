using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PriceList.Controllers;
using System.Web.Mvc;

namespace PriceListTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void List_ReturnsView()
        {
            var controller = new HomeController();
            var result = controller.List() as ViewResult;
            Assert.AreEqual("List", result.ViewName);
        }

    }
}
