using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
        public ActionResult Create()
        {
            if (Request.Form.Count > 0)
            {
                string catalogCode = Request.Form["CatalogCode"];
                string catalogName = Request.Form["CatalogName"];

                DataClasses1DataContext context = new DataClasses1DataContext();

                Catalog catalog = new Catalog();
                catalog.CatalogCode = catalogCode;
                catalog.CatalogName = catalogName;
                context.Catalogs.InsertOnSubmit(catalog);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult SanPhams()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
        public ActionResult Details(int id)
        {

            DataClasses1DataContext context = new DataClasses1DataContext();

            Catalog cate = context.Catalogs
                .FirstOrDefault(x => x.Id == id);
            return View(cate);
        }
    }
}