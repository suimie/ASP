using SurveyOnline.Models;
using SurveyOnline.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.Controllers
{
    public class AnswerSurveyController : Controller
    {
        private ApplicationDbContext _context;

        public AnswerSurveyController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: AnswerSurvey
        public ActionResult Index()
        {
            var surveys = _context.Surveys.ToList();

            return View(surveys);
        }

        public ActionResult Answer(int surveyId)
        {
            var viewModel = new AnswerFormViewModel()
            {
                Survey = _context.Surveys.Find(surveyId),
                Response = new Response()
            };

            viewModel.Response.SurveyId = surveyId;

            return View("AnswerForm", viewModel);
        }

        public ActionResult Save(AnswerFormViewModel answer)
        {
            //Server side validation
            if (!ModelState.IsValid)
            {
                //The form is not valid --> return same form to the user

                return View("AnswerForm", answer);
            }

            _context.Responses.Add(answer.Response);

            _context.SaveChanges();

            return View("SaveConfirmation");
        }

    }
}