using Microsoft.AspNetCore.Mvc;
using TPLecture.DBLib;
using TPLectures.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPLectures.Web.Controllers
{
    public class PublicController : Controller
    {
        public IActionResult Index()
        {
            List<Livre> livres = LivreDB.All();
            String titre = "La liste des fiches de lectures";

            IndexPublicViewModel model = new IndexPublicViewModel();
            model.Livres = livres;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Lecture(int id)
        {
            Livre livre = LivreDB.Find(id);
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
