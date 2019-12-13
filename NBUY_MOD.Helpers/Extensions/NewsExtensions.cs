using NBUY_MOD.Entities.DTO;
using NBUY_MOD.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.Helpers.Extensions
{
    public static class NewsExtensions
    {
        public static NewsDTO GetNewsDto(News news)
        {
            NewsDTO newsDTO = new NewsDTO
            {
                NewsSubTitle = news.NewsSubtitle,
                NewsTitle = news.NewsTitle,
                NewsImagePath = news.NewsImagePath,
                NewsInformation = news.NewsContent.Substring(0, 20)
            };

            return newsDTO;
        }

        public static List<NewsDTO> GetNewsDto(List<News> news)
        {
            List<NewsDTO> newslist = new List<NewsDTO>();
            newslist = news.Select(i => new NewsDTO
            {
                NewsSubTitle = i.NewsSubtitle,
                NewsTitle = i.NewsTitle,
                NewsImagePath = i.NewsImagePath,
                NewsInformation = i.NewsContent.Substring(0, 20)
            }).ToList();
            return newslist;
        }
    }
}
