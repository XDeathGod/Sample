using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;
using Newtonsoft.Json;

namespace COnt.Controllers
{ 
  //  [HandleError]
    public class JsonController : Controller
    {
        [OutputCache(Duration =20,Location = System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Index()
        {
           // throw new Exception("sorry exception found");

            return View();
        }

        public JsonResult result()
        {
            Address address = new Address()
            {
                AddressRoad = "fuck yeah",
                City = "Hell",
                State = "I_Dont_know"
            };
            var js = JsonConvert.SerializeObject(address);
            return  Json(js, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult resul(Address address)
        {
           
            System.Threading.Thread.Sleep(4000);

            return Json("true", JsonRequestBehavior.AllowGet);
    
        }
      //  [HandleError]
        public ActionResult Error()

        {
            throw new Exception("sorry exception found");
          //  return View();
        }

        public ActionResult co()
        {
            return View();
        }

       
        public JsonResult countres()
        {
            List<string> addresses = new List<string>()
            {
                "dddd","dddddddddd","fgvfd","vfcdvdf b"
            };
            var c = JsonConvert.SerializeObject(addresses);
            return Json(c, JsonRequestBehavior.AllowGet);
        }

        public JsonResult st()
        {
            List<string> addresses = new List<string>()
            {
                "state","dddddddddd","fgvfd","vfcdvdf b"
            };
            var c = JsonConvert.SerializeObject(addresses);
            return Json(c, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ci()
        {
            List<string> addresse = new List<string>()
            {
                "city","dddddddddd","fgvfd","vfcdvdf b"
            };
            var c = JsonConvert.SerializeObject(addresse);
            return Json(c, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Partial()
        {
            List<Address> addresses = new List<Address>()
            {
                new Address()
                {
                     AddressRoad = "fuck the road",
                      City="Bankgogko",
                      State="i dnt know bro"
                },
                 new Address()
                {
                     AddressRoad = "suck da the road",
                      City="Bankguihhhogko",
                      State="i dnt know bro"
                }
            };
            return View(addresses);
        }

    }
}