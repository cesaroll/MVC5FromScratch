using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S05_L16_AttributeRouting.Controllers
{
    public class HomeController : Controller
    {
        [Route("About")]
        public String Index()
        {
            return "HomeController Index Action";
        }

        [Route("About/{id}")]
        public String Index(int id)
        {
            return "HomeController Index Action Index: " + id;
        }

        
    }
}