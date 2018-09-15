using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;

namespace COnt.Controllers
{
    [RoutePrefix("Route")]
    public class RouteController : Controller
    {
        // GET: Route
        [Route("")]
        public ActionResult student()
        {
            var f = stu();
            return View(f);
        }
        [Route("{id:int}")]
        public ActionResult studentbyid(int id)
        {
            var b = stu().FirstOrDefault(x => x.Id == id);
            return View(b);
        }
        [Route("{id}/adress")]
        public ActionResult studentaddress(int id)
        {
            var c = stu().Where(x => x.Id == id).Select(x => x.Adress).FirstOrDefault();
            return View(c);
        }
        private static List<Student> stu()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name= "VIkas",
                    Adress = new Address()
                    {
                            AddressRoad="Ganga",
                             City="Varanasi",
                              State="UP"
                    }


                },
                 new Student()
                {
                    Id = 2,
                    Name= "Tsuande",
                    Adress = new Address()
                    {
                            AddressRoad="Konaha",
                             City="Village",
                              State="Naruto"
                    }


                }




        };
        }

        [Route("~/id")]

        public string act(string id)
        {
            return id;
        }
    }
}