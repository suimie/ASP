using SurveyOnline.Models;
using SurveyOnline.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyOnline.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext _context;

        public SurveyController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Survey
        [Authorize]
        public ActionResult Index(String SearchString)
        {
            var surveys = _context.Surveys.AsQueryable();

            if (!String.IsNullOrWhiteSpace(SearchString))
            {
                surveys = from s in surveys where s.Title.Contains(SearchString) || s.SurveyQuestion.Contains(SearchString) select s;
                //surveys = surveys.Where(p => p.Title.Contains(SearchString) || p => p.SurveyQuestion.Contains(SearchString));
                ViewBag.SearchPhone = SearchString;
            }

            return View(surveys.ToList());
        }

        public ActionResult Details(int id)
        {
            var surveys = _context.Surveys.SingleOrDefault(s => s.Id == id);


            return View(surveys);
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new SurveyFormViewModel()
            {
                Survey = new Survey(),
                Topics = _context.Topics.ToList()
            };

            return View("SurveyForm", viewModel);
        }

        public ActionResult Edit(int Id)
        {
            var survyeInDB = _context.Surveys.SingleOrDefault(s => s.Id == Id);

            if (survyeInDB == null)
                return HttpNotFound();

            var viewModel = new SurveyFormViewModel()
            {
                Survey = survyeInDB,
                Topics = _context.Topics.ToList()
            };

            return View("SurveyForm", viewModel);
        }

        public ActionResult Save(Survey survey)
        {
            //Server side validation
            if (!ModelState.IsValid)
            {
                //The form is not valid --> return same form to the user
                var viewModel = new SurveyFormViewModel
                {
                    Survey = survey,
                    Topics = _context.Topics.ToList()
                };

                return View("SurveyForm", viewModel);
            }

            if (survey.Id == 0)
            {
                _context.Surveys.Add(survey);
            }
            else
            {
                var surveyInDB = _context.Surveys.Single(c => c.Id == survey.Id);

                //TryUpdateModel(customerInDB);

                //This method has a security flow.


                //Manually update the fields I want.
                surveyInDB.Title = survey.Title;
                surveyInDB.SurveyQuestion = survey.SurveyQuestion;
                surveyInDB.TopicId = survey.TopicId;
                surveyInDB.Author = survey.Author;
                surveyInDB.DeadlineDate = survey.DeadlineDate;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Survey");
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            var survey = _context.Surveys
                .SingleOrDefault(s => s.Id == id);

            if (survey == null)
                return HttpNotFound();

            return View(survey);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var surveyInDB = _context.Surveys.Find(id);

            _context.Surveys.Remove(surveyInDB);
            _context.SaveChanges();

            return RedirectToAction("Index", "Survey");
        }

    }
}