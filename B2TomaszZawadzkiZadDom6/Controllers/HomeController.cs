using B2TomaszZawadzkiZadDom6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B2TomaszZawadzkiZadDom6.ViewModels;
using B2TomaszZawadzkiZadDom6.Models;

namespace BTomaszZawadzkiZadDom6.Controllers
{
    public class HomeController : Controller
    {
        TomaszBaseLab5Entities database = new TomaszBaseLab5Entities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult DevInfo()
        {
            return View();
        }

        public ActionResult GetStudyAid()
        {
            List<Support> allSupport = database.Support.ToList();
            List<StudyAidVM> viewAid = new List<StudyAidVM>();

            foreach (var site in allSupport)
            {
                StudyAidVM viewSupport = new StudyAidVM(site.Website, site.Function, site.Logo);
                    viewAid.Add(viewSupport);
            }

            return View(viewAid);
        }

        public ActionResult GetTemplates()
        {
            List<Template> allTemplates = database.Template.ToList();
            List<TemplatesVM> viewTemplate = new List<TemplatesVM>();

            foreach (var site in allTemplates)
            {
                TemplatesVM viewTemp = new TemplatesVM(site.Website, site.Content, site.Level, site.Logo);
                viewTemplate.Add(viewTemp);
            }
            return View(viewTemplate);
        }

        [HttpGet]
        public ActionResult GetData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetData(UserData user)
        {
            string alias = user.Mood + " " + user.Name + " " + user.Feature;
            ViewBag.userAlias = alias;
            return View("UserAlias");
        }
    }
}