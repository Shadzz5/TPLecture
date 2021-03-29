using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TPLectureDB.EF.Models;
using TPLectures.Web.Models;

namespace TPLectures.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            LecturesContext context = new LecturesContext();
            List<Livre> livres = context.Livre.ToList();
            String titre = "Accès administration";

            IndexAdminViewModel model = new IndexAdminViewModel();
            model.Livres = livres;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Lecture(int id)
        {
            LecturesContext context = new LecturesContext();
            Livre livre = context.Find(id);
            String titre = "Un livre";
            if (livre == null)
            {

                return NotFound();
            }
            LectureAdminViewModel model = new LectureAdminViewModel();
            model.Livre = livre;
            model.Titre = titre;

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            LivreDB.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Modifier(int id)
        {
            Livre livre = LivreDB.Find(id);
            String titre = "Un livre";
            ModifierAdminViewModel model = new ModifierAdminViewModel();
            model.Livre = livre;
            model.Titre = titre;
            return View(model);
        }
        [HttpPost]
        public IActionResult ConfirmationModif(Livre livre)
        {
            LivreDB.Update(livre);
            return RedirectToAction("Index");
        }
    }
}