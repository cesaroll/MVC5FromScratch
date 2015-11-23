using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ces.Sch.Data.DependencyInversion;
using Ces.Sch.Data.Interfaces;

namespace School.Web.Controllers
{
    public class StudentController : Controller
    {
        public IStudentRepository StudentRepository { get;}

        public StudentController()
        {
            StudentRepository = DataDIConfig.Resolve<IStudentRepository>();
        }

        // GET: Student
        public ActionResult GetAll()
        {
            var students = StudentRepository.GetAll();

            return View("StudentAll", students);
        }
    }
}