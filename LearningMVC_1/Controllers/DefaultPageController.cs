using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC_1.Controllers
{
    public class DefaultPageController : Controller
    {
        // GET: DefaultPage
        public ActionResult MyDefaultPage()
        {
            return View();
        }
    }
}