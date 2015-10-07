using ShopOnline.Models.EVShop20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class ProductController : Controller
    {
        EVShop20 db = new EVShop20();
        // GET: Product
        public ActionResult List(String SupplierId = "", int CategoryId = 0, String Keywords = "")
        {
            if (SupplierId != "")
            {
                var model = db.Products
                    .Where(p => p.SupplierId == SupplierId);
                return View(model);
            }
            else if (CategoryId != 0)
            {
                var model = db.Products
                    .Where(p => p.CategoryId == CategoryId);
                return View(model);
            }
            else if (Keywords != "")
            {
                var model = db.Products
                    .Where(p => p.Name.Contains(Keywords));
                return View(model);
            }
            return View(db.Products);
        }
        public ActionResult Detail(int Id)
        {
            var model = db.Products.Find(Id);
            model.Views++;//tang so lan xem
            var views = Request.Cookies["views"];//lay cookie
            if(views==null)
            {
                views = new HttpCookie("views");
            }
            views.Values[Id.ToString()] = Id.ToString();//bo sung hang da xem
            views.Expires = DateTime.Now.AddMonths(1);//dat thoi han
            Response.Cookies.Add(views);

            var keys = views.Values.AllKeys.Select(k => int.Parse(k)).ToList();//lay list<int> chua ma hang da xem tu cookie
            ViewBag.Views = db.Products.Where(p => keys.Contains(p.Id));
            
            return View(model);
        }
    }
}