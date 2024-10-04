using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}