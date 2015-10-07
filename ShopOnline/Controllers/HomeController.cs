using ShopOnline.Models.EVShop20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Data.Entity;

namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        EVShop20 db = new EVShop20();
        public int PageSize = 9;
        // GET: Home
        public ActionResult Index(int? page, String SupplierId = "", int CategoryId = 0, String Keywords = "")
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(db.Products.OrderBy(p=>p.Available==true).ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("_Category", model);
        }
        public ActionResult Supplier()
        {
            var model = db.Suppliers;
            return PartialView("_Supplier", model);
        }
        public ActionResult Search()
        {
            var name = Request["term"];
            var data = db.Products.Where(p => p.Name.Contains(name))
                        .Select(p => p.Name).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SubProduct()
        {
            return PartialView("_SubProduct");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Intro()
        {
            return View();
        }
        public ActionResult Feedback()
        {
            return View();
        }
    }
}