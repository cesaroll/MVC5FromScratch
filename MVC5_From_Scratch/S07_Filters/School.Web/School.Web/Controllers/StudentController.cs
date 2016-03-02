using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ces.Sch.Data.DependencyInversion;
using Ces.Sch.Data.Interfaces;
using Ces.Sch.Web.Filters;

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
        //[CustomAuth(false)]
        [CustomAuth(true)]
        //[CustomAuthentication]
        public ActionResult GetAll()
        {
            var students = StudentRepository.GetAll();

            return View("StudentAll", students);
        }
        
        //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
        [Exception]
        public ActionResult Index()
        {
            throw new Exception("Exception from Student-Index");
            return View();
        }
    }
}