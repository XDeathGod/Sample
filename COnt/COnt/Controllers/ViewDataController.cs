using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;

namespace COnt.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        public ActionResult Index()
        {
            var nope = new List<string>() { "vikas", "luffy", "hentai", "Tsuande" };
            ViewBag.Tsuande = nope;
            return View();
        }

        public ActionResult Pain()
        {
            List<Employee> vs = new List<Employee>()
             {
                 new Employee(){ id=1, Email="fuck@gmsil.com", Name="Joker" } ,
                                  new Employee(){ id=2, Email="fuck@gmsil.com", Name="Joker" } ,

                                                   new Employee(){ id=3, Email="fuck@gmsil.com", Name="Joker" } ,

             };
            ViewBag.fibk = vs;

            return View();
        }
    }
}