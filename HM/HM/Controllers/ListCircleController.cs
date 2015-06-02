using HM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HM.Controllers
{
    public class ListCircleController : Controller
    {
        private dbHandMadeEntities db = new dbHandMadeEntities();
        // GET: ListCircle
        public ActionResult Index()
        {
            return View();
        }

        //View top artisans in base
        public ActionResult TopList(string city)
        {
            var artisans = 
                (from artisan in db.Artisans 
                 where artisan.City == city
                 select artisan)
                .ToList();
            return View(artisans);
        }

        //View categories
        public ActionResult CategoryList()
        {
            var categories = (from category in db.Categories select category).ToList();
            return View(categories);
        }
    }
}