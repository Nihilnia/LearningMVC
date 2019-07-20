using LearningMVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC_1.Controllers
{
    public class MerhabaController : Controller
    {
        // GET: Merhaba
        public ActionResult MerhabaSayfasi()
        {
            Personel p01 = new Personel() { id = 1, personelAdi = "Nihil"};
            return View();
        }
    }
}