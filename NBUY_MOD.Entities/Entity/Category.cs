using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.Entities.Entity
{
    public class Category
    {
        public Category()
        {
            News = new List<News>();
        }
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        
        public IEnumerable<News> News { get; set; }
    }

    
}
