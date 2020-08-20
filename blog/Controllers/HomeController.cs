using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            return View(context.Bloglar.ToList());
        }
    }
}