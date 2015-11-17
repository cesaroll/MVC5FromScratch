using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace S05_L14_CatchAll.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id)
        {
            var values = RouteData.Values;
            
            var output = new StringBuilder();

            output.AppendFormat("This is Index: [{0}] <br><br>These are values:<br><br>", id);

            foreach (var item in values)
            {
                output.Append(item.Key).Append(" : ").Append(item.Value).Append("<br>");
            }

            return output.ToString();

        }

        public string Start()
        {
            return "This is Start Action in Home Controller";
        }

    }
}