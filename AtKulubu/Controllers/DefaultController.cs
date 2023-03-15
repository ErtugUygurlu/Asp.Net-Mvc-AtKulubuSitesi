using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtKulubu.Models.Entity;

namespace AtKulubu.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        AtDBEntities db= new AtDBEntities();
        public ActionResult Index()
        {
            var degerler= db.TBLBILGI.ToList();
            return View(degerler);
        }
    }
}