using System.Collections.Generic;
using System.Web.Mvc;
using Models.Interfaces;

namespace S06_L18_Views.Helpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString DisplaySubjects(this HtmlHelper helper, IEnumerable<ISubject> subjects)
        {
            var builder = new TagBuilder("div");

            foreach (var subject in subjects)
            {
                var subjectBuilder = new TagBuilder("span");
                subjectBuilder.SetInnerText(subject.Name);

                builder.InnerHtml += subjectBuilder.InnerHtml + "<br />";
            }
            
            return new MvcHtmlString(builder.ToString());

        }
    }
}