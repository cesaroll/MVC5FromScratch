using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Interfaces;
using Repo.Interfaces;

namespace S06_L18_Views.Controllers
{
    public class SubjectController : Controller
    {
        private IRepository<ISubject> _subjectRepo;

        public SubjectController(IRepository<ISubject> subjects)
        {
            _subjectRepo = subjects;
        }

        // GET: Subject
        public ActionResult Get()
        {
            var subjects = _subjectRepo.GetAll();
            return View("SubjectDisplay", subjects);
        }
    }
}