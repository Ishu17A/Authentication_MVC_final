using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Authentication_MVC.Controllers
{
    public class EmployeeController : Controller
    {
    [Authorize (Roles ="Admin")]
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "Employee")]
        public ActionResult Index1()
        {
            return View();
        }
    }
}