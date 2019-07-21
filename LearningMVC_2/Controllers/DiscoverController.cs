using LearningMVC_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC_2.Controllers
{
    public class DiscoverController : Controller
    {
        // GET: Discover
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Deneme(int getID, string getName)
        {
            //https://localhost:44301/Discover/Deneme?id=3475634&nick=Nihil

            User user01 = new User {userID = getID, userName = getName};
            return View(user01);
        }
    }
}