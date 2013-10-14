using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceList.Controllers;
using PriceList.Models;
using System.Web.Mvc;
using Domain;
using System.Collections.Generic;

namespace PriceListTests_VS
{
    [TestClass]
    public class ListControllerTests : IGetList
    {
        [TestMethod]
        public void List_ReturnsListView()
        {
            var controller = new ListController(this);
            var result = controller.List() as ViewResult;
            Assert.AreEqual("List", result.ViewName);
        }

        [TestMethod]
        public void List_ViewHasModel()
        {
            var controller = new ListController(this);
            var result = controller.List() as ViewResult;
            var viewModel = controller.ViewData.Model as ListModel;
            Assert.IsInstanceOfType(viewModel, typeof(ListModel));
        }

        [TestMethod]
        public void List_ModelHasListOfItems()
        {
            var controller = new ListController(this);
            var result = controller.List() as ViewResult;
            var viewModel = controller.ViewData.Model as ListModel;
            Assert.AreEqual(2, viewModel.Items.Count);
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

        public List<string> GetList()
        {
            return new List<string>{"product 1", "another product"};
        }
    }
}
