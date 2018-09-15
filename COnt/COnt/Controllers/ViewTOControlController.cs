using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;

namespace COnt.Controllers
{
    public class ViewTOControlController : Controller
    {
        // GET: ViewTOControl
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(string first,string last)
        {
            return "Paramters are" + first + "and" + last;
        }
       // [HttpPost]
        public string Inde(FormCollection form)
        {
            string first = form["first"];
            string last = form["last"];
            return "Paramters are" + first + "and" + last;
        }
        [HttpPost]
        public string Ind()

        {
            string first = Request["first"];
            string last = Request["last"];
            return "Paramters are" + first + "and" + last;
        }
        [HttpPost]
        public string In(form p)
        {
           // form f = new form();
           
            return "Paramters are" + p.first + "and" + p.last;
        }
        
        public ActionResult nop()
        {       
            
                return View();
            
          //  return View("Index");
        }
        [HttpPost]
        public ActionResult nope(form f)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("nop");
        }
    }
}