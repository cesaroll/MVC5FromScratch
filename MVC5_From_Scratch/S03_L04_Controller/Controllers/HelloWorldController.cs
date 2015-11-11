using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S03_L04_Controller.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string SayHello()
        {            
            var name = RouteData.Values["name"] as string;
            var surname = Request.QueryString["surname"];
            var url = Request.Url;
            return string.Format("Hello {0} {1}.<br> Your url is:<br>{2}", name, surname, url);
        }

        public string SayHello2(string name)
        {
            return string.Format("Hello {0}", name);
        }
        
        public string SayHello3(string name, string surname = "Lerma")
        {
            return string.Format("Hello {0} {1}", name, surname);
        }
    }
}