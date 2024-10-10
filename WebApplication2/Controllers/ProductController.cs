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
            List<Product> dsProduct = null;
            if (Request.QueryString.Count==0)
            {
                dsProduct = context.Products.ToList();
            }
            else
            {
                double min = double.Parse(Request.QueryString["txtMin"]);
                double max = double.Parse(Request.QueryString["txtMax"]);
                dsProduct = context.Products.Where(x => x.UnitPrice >= min && x.UnitPrice <= max).ToList();
            }
            return View(dsProduct);
        }
        public ActionResult Details(int id)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Product p = context.Products.FirstOrDefault(x => x.Id == id);
            return View(p);
        }

    }
}