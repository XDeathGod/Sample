using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COnt.Controllers
{
    public class HomeController : Controller
    {
     public ViewResult Index()
        {
            return View();
        }
public ActionResult AboutUs()
        {
            return View();
        }
        public ViewResult fuck()
        {
            return View("Index");
        }
     
    }
}