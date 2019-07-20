using LearningMVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC_1.Controllers
{
    public class CommodusController : Controller
    {
        // GET: Commodus
        public ActionResult NiceSong()
        {
            var song01 = new Class1() {songID = 1, artist = "aaa"};
            var song02 = new Class2() {nick = "Nihil"};
            //return View(song02);
            return RedirectToAction("MyDefaultPage", "DefaultPage", new { SortBy = "Nihil" });
        }
    }
}