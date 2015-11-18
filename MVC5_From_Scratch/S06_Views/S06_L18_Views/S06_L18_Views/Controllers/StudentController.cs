﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Interfaces;
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

        public ActionResult GetByName(string name)
        {
            return View("StudentDisplay");
        }

        public ActionResult Get()
        {
            return View("StudentAll", _studentRepo.GetAll());
        }
    }
}