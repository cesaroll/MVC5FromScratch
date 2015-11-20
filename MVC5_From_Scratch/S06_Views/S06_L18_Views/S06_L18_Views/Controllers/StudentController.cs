using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Interfaces;
using Models.Models;
using Repo.Interfaces;

namespace S06_L18_Views.Controllers
{
    public class StudentController : Controller
    {
        private IRepository<IStudent> _studentRepo;

        public StudentController(IRepository<IStudent> studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var student = _studentRepo.Get(id);

            //Notice View Bag is a short hand dynamic property for ViewData
//            ViewBag.Name = student.Name;
//            ViewBag.Surname = student.Surname;

            ViewData["Name"] = student.Name;
            ViewData["Surname"] = student.Surname;

            return View("StudentDisplay", student);
        }

        [HttpPost]
        public ActionResult GetById(Student student)
        {
            return View("Saved", student);
        }

        [HttpGet]
        public ActionResult GetByName(string name)
        {
            return View("StudentDisplay");
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View("StudentAll", _studentRepo.GetAll());
        }

        [HttpGet]
        public ActionResult StudentAll()
        {
            return RedirectToAction("Get");
        }

        public ActionResult Thanks()
        {
            return View();
        }

    }
}