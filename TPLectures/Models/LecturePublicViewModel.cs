using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Models
{
    public class LecturePublicViewModel
    {
        public Livre Livre { get; set; }
        public String Titre { get; set; }
    }
}
