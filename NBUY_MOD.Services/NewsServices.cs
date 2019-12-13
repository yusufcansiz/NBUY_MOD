using NBUY_MOD.DAL.Database;
using NBUY_MOD.DAL.Repository;
using NBUY_MOD.Entities;
using NBUY_MOD.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.Services
{
    public class NewsServices
    {
        //Burası hatalı kullanım, çünkü EF bağımlılığı var
        //private ProjectContext database;

        //public NewsServices()
        //{
        //    database = new ProjectContext();
        //}

        private NewsRepository _newsRepository;

        public NewsServices()
        {
            _newsRepository = new NewsRepository();
        }

        public List<News> GetNews()
        {
            var newsList = _newsRepository.GetAllNews();

            return newsList;
        }
       


    }
}
