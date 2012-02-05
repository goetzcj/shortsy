using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shortsy2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string linkid)
        {
            //Test comment
            Response.StatusCode = 302;
            Response.RedirectLocation = (string.IsNullOrWhiteSpace(linkid)
                    ? "http://www.aspireforit.com"
                    : string.Format("http://bit.ly/{0}", linkid));
            return new ContentResult();
        }
    }
}
