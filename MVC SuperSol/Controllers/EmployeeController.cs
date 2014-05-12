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
            model.Employees= repo.ReadEmployeesFromDB();
            return View(model);
        }

    }
}
