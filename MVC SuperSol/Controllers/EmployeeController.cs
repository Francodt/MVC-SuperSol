using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SuperSol.Models;
using MVC_SuperSol.Repositories;

namespace MVC_SuperSol.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult List()
        {
            var repo = new EmployeeRepository();
            var model = new EmployeeListModel();
            model.Employees = repo.ReadEmployeesFromDB();

            var model1 = new EmployeeEditModel();
            model1.Employees = repo.GetEmployeeByID();

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var repo = new EmployeeRepository();
            var model = new EmployeeEditModel();
            model.Employees = repo.GetEmployeeByID();
            return View(model);
        }
    }
}
