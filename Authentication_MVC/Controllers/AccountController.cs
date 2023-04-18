using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Authentication_MVC.Models;
using System.Web.Security;

namespace Authentication_MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {

            using (var context = new EmployeeContext())
            {
                bool isValid = context.Employees.Any(x => x.UserName == employee.UserName && x.Password == employee.Password);

                if (isValid == true)
                {
                    if(employee.Role == "Admin")
                    {
                        Session["Username"] = employee.UserName;
                        FormsAuthentication.SetAuthCookie(employee.UserName, false);
                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        Session["Username"] = employee.UserName;
                        FormsAuthentication.SetAuthCookie(employee.UserName, false);
                        return RedirectToAction("Index1", "Employee");
                    }
                    
                }
                ModelState.AddModelError("", "invalid username and passward");
            return View();
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Employee model)
        {
            using (var context = new EmployeeContext())
            {
                model.Role = "Employee";
                context.Employees.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}