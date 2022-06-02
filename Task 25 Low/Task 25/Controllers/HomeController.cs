using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_23.Models;

namespace Task_23.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork("DefaultConnection");
        public ActionResult Index()
        {  
            return View(db.Articles.GetAll());
        }
        public ActionResult Article(int Id)
        {
            var art = db.Articles.Get(Id);
            if(art != null)
            {
                return View("Article", art);
            }
            return View("Article");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}