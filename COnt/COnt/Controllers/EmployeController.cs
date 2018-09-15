using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppModel;
using MyApp;
using MyApp.DBoperation;

namespace COnt.Controllers
{
    public class EmployeController : Controller
    {
        EmployeeRepository repository = null;
        // GET: Employe
        public EmployeController()
        {
            repository = new EmployeeRepository();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int id = repository.AddEmployee(model);
                if (id>0 )
                {
                    ModelState.Clear();
                    ViewBag.Hello = "Sucessfully Data Added";
                  //  return View();
                }
            }
            return View();
        }

        public ActionResult GetEmploye()
        {
            var con = repository.GetAllEmployees();
            return View(con);
        }

        public ActionResult EmployeId(int id)
        {
            var con = repository.GetEmployee(id);
            return View(con);
        }
        public ActionResult Edit(int id)
        {
            var con = repository.GetEmployee(id);
            return View(con);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel model)
        {
           if(ModelState.IsValid)
            {
                repository.UpdateEmployee(model.Id, model);
                return RedirectToAction("GetEmploye");
            }
           return View();

        }
        //public ActionResult Delete(int id)
        //{
        //    var con = repository.GetEmployee(id);
        //    return View(con);
        //}
      //  [HttpPost]
        public ActionResult Delet(int id)
        { 
           // if(ModelState.IsValid)
            {
                repository.DeleteEmployee(id);
                return RedirectToAction("GetEmploye");
            }
           // var con = repository.(id);
           return View();
        }
    }
}//