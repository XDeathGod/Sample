using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COnt.Models;


namespace COnt.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Emp(int id, int? code=444)
        {
            return "id=" + id + "code is :"+ code;
        }

        public ViewResult Suck()
        {
            var data = Employee();
            return View(data);
        }
        public ViewResult Hello()
        {
            Employee emp = new Employee()
            {
                Name = "Vikas Pandey",
                Email = "Varanasi / Ganga",
                isEmployee = true,
                
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Hello(Employee em)
        { 

            return View();
        }



        private Employee Employee()
        {
            return new Employee()
            {
                id= 2,
                Name="Donquixote Doflamingo",
                Email="Dressrosa"
            };
        }
       
    }
}