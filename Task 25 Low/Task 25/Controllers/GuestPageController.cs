using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_23.Models;

namespace Task_23.Controllers
{
    public class GuestPageController : Controller
    {
        UnitOfWork db = new UnitOfWork("DefaultConnection");
        public ActionResult GuestPage()
        {
            ViewBag.feed = db.Feedbacks.GetAll().OrderBy(x => x.FeedbackDate);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuestPage(FeedbackModel feedback)
        {
            feedback.FeedbackDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Feedbacks.Create(feedback);
                db.Save();
                return RedirectToAction("GuestPage");
            }
            return GuestPage();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}