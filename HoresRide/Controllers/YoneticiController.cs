using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoresRide.Models.Entity;

namespace HoresRide.Controllers
{
    public class YoneticiController : Controller
    {

        // GET: Yonetici
        HorsesEntities1 db = new HorsesEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBLBilgi.ToList();
            return View(degerler);
        }
    }
}