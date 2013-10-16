using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PriceList.Models;
using Domain;

namespace PriceList.Controllers
{
    public class ListController : Controller
    {
        private IGetList _getList;

        public ListController(IGetList getList)
        {
            _getList = getList;
        }

        //
        // GET: /List/

        public ActionResult List()
        {
            ViewBag.Message = "Your contact page.";
            var model = new ListModel();

            foreach (var product in _getList.GetList())
            {
                var item = new ListModelItem() { Name = product };
                model.Items.Add(item);
            }

            return View("List", model);
        }

        [HttpPost]
        public ActionResult List(ListModel model)
        {
            var test = model;
            return RedirectToAction("List", "List");
        }


        ////
        //// GET: /List/Details/5

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        ////
        //// GET: /List/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /List/Create

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /List/Edit/5

        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /List/Edit/5

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /List/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /List/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
