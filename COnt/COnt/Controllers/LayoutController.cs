using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COnt.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        [Route("india")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("La")]
        public ActionResult Inde()
        {
            return View();
        }

    }
}