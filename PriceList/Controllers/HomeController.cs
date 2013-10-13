using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PriceList.Models;
using Domain;

namespace PriceList.Controllers
{
    public class HomeController : Controller
    {
        private IStoreAndGetList _storeAndGetList;

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List()
        {
            ViewBag.Message = "Your contact page.";
            var model = new ListModel();
            model.Items.Add("product 1");
            model.Items.Add("another product");

            return View("List", model);
        }
    }
}
