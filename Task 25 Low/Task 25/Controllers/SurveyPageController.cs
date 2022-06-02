using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_23.Models;

namespace Task_23.Controllers
{
    public class SurveyPageController : Controller
    {
        QuizAnswerModel res = new QuizAnswerModel();
        UnitOfWork db = new UnitOfWork("DefaultConnection");

        [HttpGet]
        public ActionResult Index()
        {
            return View(res);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(QuizAnswerModel answers)
        {
            if(ModelState.IsValid)
            {
                db.Answers.Create(res);
                db.Save();
                return View("Submitted", answers);
            }
            return Index();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}