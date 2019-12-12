using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.Entities
{
    public class News
    {
        public int Id { get; set; }

        public string NewsName { get; set; }

        public string NewsDescription { get; set; }

        //NewsDetails
        public string NewsTitle { get; set; }

        public string NewsSubtitle { get; set; }

        public string NewsContent { get; set; }

        public string NewsImagePath { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
