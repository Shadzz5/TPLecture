using Microsoft.AspNetCore.Mvc;
using TPLectures.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLectureDB.EF.Models;

namespace TPLectures.Web.Controllers
{
    public class PublicController : Controller
    {
        LecturesContext context = new LecturesContext();
        public IActionResult Index()
        {
            List<Livre> livres = context.Livre.ToList();
            String titre = "La liste des fiches de lectures";

            IndexPublicViewModel model = new IndexPublicViewModel();
            model.Livres = livres;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Lecture(int id)
        {
            Livre livre = context.Livre.Find(id);
            String titre = "Un livre";
            if (livre == null)
            {
                return NotFound();
            }
            LecturePublicViewModel model = new LecturePublicViewModel();
            model.Livre = livre;
            model.Titre = titre;

            return View(model);
        }
    }
}
