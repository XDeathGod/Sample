using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COnt.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        public ActionResult Index()
        {
            TempData["vikas"] = "hellow from the other side";
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.vikas = TempData.Peek("vikas");
          //  TempData.Keep();
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.vikas = TempData["vikas"];

            return View();
        }
    }
}