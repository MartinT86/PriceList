using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceList.Controllers;
using PriceList.Models;
using System.Web.Mvc;

namespace PriceListTests_VS
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void List_ReturnsListView()
        {
            var controller = new HomeController();
            var result = controller.List() as ViewResult;
            Assert.AreEqual("List", result.ViewName);
        }

        [TestMethod]
        public void List_ViewHasModel()
        {
            var controller = new HomeController();
            var result = controller.List() as ViewResult;
            var viewModel = controller.ViewData.Model as ListModel;
            Assert.IsInstanceOfType(viewModel, typeof(ListModel));
        }

        [TestMethod]
        public void List_ModelHasListOfItems()
        {
            var controller = new HomeController();
            var result = controller.List() as ViewResult;
            var viewModel = controller.ViewData.Model as ListModel;
            Assert.AreEqual(0, viewModel.Items.Count);
        }

        [TestMethod]
        public void List_ModelCreatedFromDomain()
        {
            //var controller = new HomeController(this);
            //var newModel = controller.GetList();
            //var result = controller.List() as ViewResult;
            //var viewModel = controller.ViewData.Model as ListModel;
            //Assert.AreEqual(0, viewModel.Items.Count);
        }
    }
}
