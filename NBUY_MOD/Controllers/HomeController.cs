using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using NBUY_MOD.Models;
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
        private readonly NewsServices _newsServices;
        private readonly CategoryServices _categoryServices;

        public HomeController()
        {
            _newsServices = new NewsServices();
            _categoryServices = new CategoryServices();
        }

        
        //[HttpGet] hatalı kullanım
        //[HttpPost]
        [AcceptVerbs("GET","POST")]
        public ActionResult Index()
        {
            List<News> newlist = new NewsServices().GetNews();

            List<Category> categorylist = new CategoryServices().GetCategories();

            var model = new HomeIndexViewModel
            {
                Categories = categorylist,
                News = newlist
            };

            return View(model);
        }
    }
}