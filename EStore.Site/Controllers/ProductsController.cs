using EStore.Site.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EStore.Site.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index01()
        {
            var db = new AppDbContext();
            var data = db.Products.OrderByDescending(p => p.UnitPrice).ToList();
            return View(data);
        }
        public ActionResult Index02()
        {
            return View();
        }
    }
}