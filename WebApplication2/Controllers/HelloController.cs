using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmlaMVC()
        {
            return Content("Hôm nay em học MVC");
        }
        public ActionResult HocMVCKhongKho()
        {
            ViewBag.ThongDiep = "Hoc MVC kho";
            return View();
        }

        public ActionResult HocMVC()
        {
            ViewBag.Message = "Hôm nay bùn ngủ qua hà";
            return View();
        }
    }
}