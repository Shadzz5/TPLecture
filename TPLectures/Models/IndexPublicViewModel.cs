using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class IndexPublicViewModel
    {
        public List<Livre> Livres { get; set; }
        public String Titre { get; set; }
    }
}
