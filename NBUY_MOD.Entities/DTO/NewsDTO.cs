using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_MOD.Entities.DTO
{
    public class NewsDTO
    {
        //DTO olması için entity den eksik veya fazla olması lazım
        public string NewsTitle { get; set; }

        public string NewsSubTitle{ get; set; }

        public string NewsImagePath { get; set; }

        public string NewsInformation { get; set; }


    }
}
