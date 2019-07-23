using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC_3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeList(string OrderBy, int Page)
        {
            return Content("OrderBy: " + OrderBy + " Page: " + Page);
        }
    }
}   