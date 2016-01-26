using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int num = 0;
            if (Request.Cookies["number"] != null)
            {
                num = int.Parse(Request.Cookies["number"].Value);
            }

            var cookie = new HttpCookie("number", (num + 1).ToString());
            Response.Cookies.Add(cookie);

            return View(num);
        }

    }
}
