using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NBUY_MOD.Models
{
    public class HomeIndexViewModel
    {
        public List<News> News { get; set; }

        public List<Category> Categories { get; set; }
    }
}