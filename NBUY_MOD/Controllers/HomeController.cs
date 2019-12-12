using NBUY_MOD.Entities;
using NBUY_MOD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBUY_MOD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<News> list = new NewsServices().GetNews();
            
            return View();
        }
    }
}