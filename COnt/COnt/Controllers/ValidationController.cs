using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;

namespace COnt.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inde(Valid val)
        { 
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
    }
}